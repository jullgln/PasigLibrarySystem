using MySql.Data.MySqlClient;
using PasigLibrarySystem.DATABASES;
using System;
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

    public partial class UserDashboard : Form
    {
        public UserDashboard(string currentUser)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            //for button rounder
            UIRounder.FormRounder(this, 30);
            UIRounder.RoundBtn(LogOutbtn, 30);
            //for colors
            highlightpanel.BackColor = UIColors.VividAzure;
            LogOutbtn.BackColor = UIColors.White;
            LogOutbtn.ForeColor = UIColors.DarkBlue;
            borrowbtn.BackColor = UIColors.VividAzure;
            borrowbtn.ForeColor = UIColors.White;
            reservebtn.BackColor = UIColors.VividAzure;
            reservebtn.ForeColor = UIColors.White;
            ViewDetails.BackColor = UIColors.VividAzure;
            ViewDetails.ForeColor = UIColors.White;
            //others
            welcomelbl.Text = "Welcome, " + UTILS.Session.CurrentUser + "!";
        }
        private void LoadBook(string keyword = "", string category = "All")
        {
            string sql = $"SELECT b.BookID, b.BookTitle, b.Author, b.Genre, b.Pub_Date, b.status " +
                         $"FROM books b";

            if (!string.IsNullOrEmpty(keyword))
            {
                if (category == "All")
                {
                    sql += " WHERE b.BookTitle LIKE @keyword OR b.Author LIKE @keyword OR b.Genre LIKE @keyword";
                }
                else if (category == "Title")
                {
                    sql += " WHERE b.BookTitle LIKE @keyword";
                }
                else if (category == "Author")
                {
                    sql += " WHERE b.Author LIKE @keyword";
                }
                else if (category == "Genre")
                {
                    sql += " WHERE b.Genre LIKE @keyword";
                }
            }
            DBConnect db = new DBConnect();
            db.Open();
            MySqlCommand cmd = new MySqlCommand(sql, db.GetConnection());

            if (!string.IsNullOrEmpty(keyword))
            {
                cmd.Parameters.AddWithValue("@keyword", "%" + keyword + "%");
            }

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

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
            tableview.DataSource = dt;
            tableview.ReadOnly = true;
            tableview.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        private bool LoadBookDetails(string bookID)
        {
            string sql = "SELECT BookTitle, Author, Genre, Pub_Date, Publisher, Pagecount, ISBN, status, Shelf_Number " +
                         "FROM books WHERE BookID = @bookID";
            DBConnect db = new DBConnect();
            db.Open();

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, db.GetConnection());
                cmd.Parameters.AddWithValue("@bookID", bookID);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        DATABASES.book_data.currentbookid = bookID;
                        DATABASES.book_data.currentbookname = reader["BookTitle"].ToString();
                        DATABASES.book_data.currentbookauthor = reader["Author"].ToString();
                        DATABASES.book_data.currentgenre = reader["Genre"].ToString();
                        DATABASES.book_data.currentpublishdate = reader["Pub_Date"].ToString();
                        DATABASES.book_data.currentpublisher = reader["Publisher"].ToString();
                        DATABASES.book_data.currentpagecount = reader["Pagecount"].ToString();
                        DATABASES.book_data.currentISBN = reader["ISBN"].ToString();
                        DATABASES.book_data.currentstatus = reader["status"].ToString();
                        DATABASES.book_data.currentshelfnumber = reader["Shelf_Number"].ToString();


                        string bookTitle = DATABASES.book_data.currentbookname;
                        string genre = DATABASES.book_data.currentgenre.ToString().ToLower();
                        string summary = "";

                        if (genre.Contains("horror"))
                            summary = $"A chilling horror story titled '{bookTitle}', filled with suspense and mystery.";
                        else if (genre.Contains("romance"))
                            summary = $"A heartwarming romance novel about love and destiny in '{bookTitle}'.";
                        else if (genre.Contains("fantasy"))
                            summary = $"An imaginative fantasy tale with adventure and magic in '{bookTitle}'.";
                        else if (genre.Contains("science"))
                            summary = $"A fascinating science-themed book exploring discoveries in '{bookTitle}'.";
                        else if (genre.Contains("fiction"))
                            summary = $"A captivating fiction story that brings imagination to life in '{bookTitle}'.";
                        else
                            summary = $"An interesting book titled '{bookTitle}' from the {genre} genre.";

                        DATABASES.book_data.currentabstract = summary;
                        return true;
                    }
                }
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error: " + ex.Message);
                return false;
            }
            finally
            {
                db.Close();
            }
        }

        private void MyAcclbl_Click(object sender, EventArgs e)
        {
            UTILS.Action.SwitchForm(this, new UserMyAcc());
        }

        private void BookCollectlbl_Click(object sender, EventArgs e)
        {
            UTILS.Action.SwitchForm(this, new UserBookCollection());
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

        private void borrowbtn_Click(object sender, EventArgs e)
        {
            if (tableview.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a book to borrow.");
                return;
            }

            DataGridViewRow row = tableview.SelectedRows[0];

            string status = row.Cells["Status"].Value.ToString().ToUpper();
            if (status != "AVAILABLE" && status != "RESERVED")
            {
                MessageBox.Show("This book is currently not available to borrow.");
                return;
            }

            // Save selected book info to global book_data
            book_data.currentbookid = row.Cells["BookID"].Value.ToString();
            book_data.currentbookname = row.Cells["BookTitle"].Value.ToString();
            book_data.currentbookauthor = row.Cells["Author"].Value.ToString();
            UTILS.Action.PopupForm(this, new BorrowForm());
        }

        private void reservebtn_Click(object sender, EventArgs e)
        {
            if (tableview.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a book to reserve");
                return;
            }

            DataGridViewRow row = tableview.SelectedRows[0];
            string status = row.Cells["Status"].Value.ToString();

            if (status == "AVAILABLE")
            {
                MessageBox.Show("This book is currently available. Please borrow instead.");
                return;
            }

            book_data.currentbookid = row.Cells["BookID"].Value.ToString();
            book_data.currentbookname = row.Cells["BookTitle"].Value.ToString();
            //book_data.currentbookauthor = row.Cells["Author"].Value.ToString();
            UTILS.Action.PopupForm(this, new ReserveForm());
        }
        private void ViewDetails_Click(object sender, EventArgs e)
        {
            if (tableview.SelectedRows.Count == 0) return;

            DataGridViewRow row = tableview.SelectedRows[0];
            string selectedBookID = row.Cells["BookID"].Value.ToString();

            if (LoadBookDetails(selectedBookID))
            {
                UTILS.Action.PopupForm(this, new ViewDetails());
            }
            else
            {
                MessageBox.Show("Could not load full book details.");
            }
        }

        private void search_Click(object sender, EventArgs e)
        {
            string keyword = searchtxt.Text.Trim();
            LoadBook(keyword);
            lbl2.Text = "Based on Search:";
        }

        private void UserDashboard_Load(object sender, EventArgs e)
        {
            LoadBook();
        }
    }
}
