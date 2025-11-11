using MySql.Data.MySqlClient;
using PasigLibrarySystem.DATABASES;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasigLibrarySystem.USER
{
    public partial class UserBookCollection : Form
    {
        public UserBookCollection()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            // for button rounder
            UIRounder.FormRounder(this, 30);
            UIRounder.RoundBtn(LogOutbtn, 30);
            // for colors
            LogOutbtn.BackColor = UIColors.White;
            LogOutbtn.ForeColor = UIColors.DarkBlue;
            lostbtn.BackColor = UIColors.VividAzure;
            lostbtn.ForeColor = UIColors.White;
            returnbtn.BackColor = UIColors.VividAzure;
            returnbtn.ForeColor = UIColors.White;
            searchbtn.BackColor = UIColors.VividAzure;
            searchbtn.ForeColor = UIColors.White;
            highlightpanel.BackColor = UIColors.VividAzure;
            // others
            welcomelbl.Text = "Welcome, " + UTILS.Session.CurrentUser + "!";
        }
        private void LoadBorrowedItems(string keyword = "", string category = "All")
        {
            string sql = $"SELECT b.BookID, b.BookTitle, b.Author, b.Genre, s.borrowed_date, s.return_date, s.status " +
                         $"FROM books b " +
                         $"JOIN status s ON b.BookID = s.book_id " +
                         $"WHERE s.user_id = @userid AND (s.status = 'BORROWED' OR s.status = 'RESERVED')";

            if (!string.IsNullOrEmpty(keyword))
            {
                sql += " AND (b.BookTitle LIKE @keyword OR b.Author LIKE @keyword OR b.Genre LIKE @keyword)";
            }
            DBConnect db = new DBConnect();
            db.Open();
            MySqlCommand cmd = new MySqlCommand(sql, db.GetConnection());

            cmd.Parameters.AddWithValue("@userid", DATABASES.user_data.user_id);
            if (!string.IsNullOrEmpty(keyword))
            {
                cmd.Parameters.AddWithValue("@keyword", "%" + keyword + "%");
            }

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            db.Close();

            // Add Summary column if missing
            if (!dt.Columns.Contains("Summary"))
                dt.Columns.Add("Summary", typeof(string));

            // Generate simple summaries
            foreach (DataRow row in dt.Rows)
            {
                book_data.currentbookname = row["BookTitle"].ToString();
                string genre = row["Genre"].ToString().ToLower();
                string summary = "";

                if (genre.Contains("horror"))
                    summary = $"A chilling horror story titled '{book_data.currentbookname}', filled with suspense and mystery.";
                else if (genre.Contains("romance"))
                    summary = $"A heartwarming romance novel about love and destiny in '{book_data.currentbookname}'.";
                else if (genre.Contains("fantasy"))
                    summary = $"An imaginative fantasy tale with adventure and magic in '{book_data.currentbookname}'.";
                else if (genre.Contains("science"))
                    summary = $"A fascinating science-themed book exploring discoveries in '{book_data.currentbookname}'.";
                else if (genre.Contains("fiction"))
                    summary = $"A captivating fiction story that brings imagination to life in '{book_data.currentbookname}'.";
                else
                    summary = $"An interesting book titled '{book_data.currentbookname}' from the {genre} genre.";

                row["Summary"] = summary;
            }


            dataGridView1.DataSource = dt;
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            if (dataGridView1.Columns.Contains("borrowed_date"))
                dataGridView1.Columns["borrowed_date"].HeaderText = "Date Borrowed";
            if (dataGridView1.Columns.Contains("return_date"))
                dataGridView1.Columns["return_date"].HeaderText = "Due Date";
            if (dataGridView1.Columns.Contains("status"))
                dataGridView1.Columns["status"].HeaderText = "Status";
        }

        private void LoadBookCounts()
        {
            DBConnect db = new DBConnect();

            db.Open();

            int returnedBooks = 0;

            string getUserQuery = "SELECT returned_books FROM users WHERE user_id=@userid";
            MySqlCommand cmd = new MySqlCommand(getUserQuery, db.GetConnection());

            cmd.Parameters.AddWithValue("@userid", user_data.user_id);
            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {

                    returnedBooks = Convert.ToInt32(reader["returned_books"]);

                }
                else
                {
                    borrowno.Text = "0";
                    returnno.Text = "0";
                    reader.Close();
                    return;
                }
            }


            string borrowedQuery = "SELECT borrowed_books FROM users WHERE user_id=@id";
            MySqlCommand cmd1 = new MySqlCommand(borrowedQuery, db.GetConnection());

            cmd1.Parameters.AddWithValue("@id", user_data.user_id);
            int borrowedCount = Convert.ToInt32(cmd1.ExecuteScalar());

            borrowno.Text = borrowedCount.ToString();
            returnno.Text = returnedBooks.ToString();

            db.Close();
        }


        private void Homelbl_Click(object sender, EventArgs e)
        {
            UTILS.Action.SwitchForm(this, new UserDashboard(UTILS.Session.CurrentUser));
        }

        private void MyAcclbl_Click(object sender, EventArgs e)
        {
            UTILS.Action.SwitchForm(this, new UserMyAcc());
        }

        private void Aboutlbl_Click(object sender, EventArgs e)
        {
            UTILS.Action.SwitchForm(this, new UserAbout());
        }

        private void Settingslbl_Click(object sender, EventArgs e)
        {
            UTILS.Action.SwitchForm(this, new UserSettings());
        }

        private void LogOutbtn_Click(object sender, EventArgs e)
        {
            UTILS.Action.LogOut(this, new LogIn());
        }

        private void lostbtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0) return;

            DataGridViewRow row = dataGridView1.SelectedRows[0];
            book_data.currentbookid = row.Cells["BookID"].Value.ToString();
            book_data.currentbookname = row.Cells["BookTitle"].Value.ToString();
            book_data.currentbookauthor = row.Cells["Author"].Value.ToString();
            string dateBorrowed = row.Cells["borrowed_date"].Value.ToString();

            UTILS.Action.PopupForm(this, new LostForm(dateBorrowed));
        }

        private void returnbtn_Click(object sender, EventArgs e)
        {
            string dateBorrowed = "";
            string dateReturn = "";

            DBConnect db = new DBConnect();

            try
            {
                if (dataGridView1.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a borrowed book first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                db.Open();
                string query = "SELECT borrowed_date, return_date FROM status WHERE user_ID = @userID AND book_id = @bookId";
                MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());
                cmd.Parameters.AddWithValue("@userID", user_data.user_id);
                cmd.Parameters.AddWithValue("@bookId", book_data.currentbookid);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        dateBorrowed = reader["borrowed_date"].ToString();
                        dateReturn = reader["return_date"].ToString();

                    }
                }
            }
            finally
            {
                db.Close();
            }

            ReturnForm form = new ReturnForm(dateBorrowed, dateReturn);
            form.Show();
        }

        private void UserBookCollection_Load(object sender, EventArgs e)
        {
            LoadBorrowedItems();
            LoadBookCounts();
            timetxt.Text = DateTime.Now.ToString("MM/dd/yyyy hh:mm tt");

        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            string keyword = searchtxt.Text.Trim();
            LoadBorrowedItems(keyword);
        }

        private void lbl3_Click(object sender, EventArgs e)
        {

        }
    }
}
