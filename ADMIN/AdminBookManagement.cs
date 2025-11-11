using Microsoft.VisualBasic.Devices;
using MySql.Data.MySqlClient;
using PasigLibrarySystem.DATABASES;
using PasigLibrarySystem.USER;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasigLibrarySystem.ADMIN
{
    public partial class AdminBookManagement : Form
    {
        public AdminBookManagement()
        {
            InitializeComponent();
            loadBooks();
            this.FormBorderStyle = FormBorderStyle.None;
            UIRounder.FormRounder(this, 30);
            highlightpanel.BackColor = UIColors.VividAzure;
            UIRounder.RoundBtn(LogOutbtn, 30);
            LogOutbtn.BackColor = UIColors.White;
            LogOutbtn.ForeColor = UIColors.DarkBlue;
            addbtn.ForeColor = UIColors.White;
            addbtn.BackColor = UIColors.VividAzure;
            viewdetailsbtn.ForeColor = UIColors.White;
            viewdetailsbtn.BackColor = UIColors.VividAzure;
            editbtn.ForeColor = UIColors.White;
            editbtn.BackColor = UIColors.VividAzure;
            deletebtn.ForeColor = UIColors.White;
            deletebtn.BackColor = UIColors.VividAzure;
            searchbtn.ForeColor = UIColors.White;
            searchbtn.BackColor = UIColors.VividAzure;
        }
        private void loadBooks(string keyword = "", string category = "All")
        {
            DBConnect db = new DBConnect();
            {
                db.Open();
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
                MySqlCommand cmd = new MySqlCommand(sql, db.GetConnection());

                if (!string.IsNullOrEmpty(keyword))
                {
                    cmd.Parameters.AddWithValue("@keyword", "%" + keyword + "%");
                }

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                MySqlCommand command = new MySqlCommand("SELECT * FROM books", db.GetConnection());
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dz = new DataTable();
                da.Fill(dz);
                tableview.DataSource = dz;
                tableview.ClearSelection();
                db.Close();
            }
        }
        private void LogOutbtn_Click(object sender, EventArgs e)
        {
            UTILS.Action.LogOut(this, new LogIn());
        }

        private void rep_invlbl_Click(object sender, EventArgs e)
        {
            UTILS.Action.SwitchForm(this, new AdminReports_Inventory());
        }
        private void memberlbl_Click(object sender, EventArgs e)
        {
            UTILS.Action.SwitchForm(this, new AdminMemberManagement());
        }

        private void button4_Click(object sender, EventArgs e)
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
            UTILS.Action.PopupForm(this, new ViewDetails());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UTILS.Action.PopupForm(this, new AddBookForm());
        }

        private void editbtn_Click(object sender, EventArgs e)
        {
            if (tableview.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a book to edit.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataGridViewRow row = tableview.SelectedRows[0];
            string selectedBookID = row.Cells["BookID"].Value.ToString();

            if (LoadBookDetails(selectedBookID))
            {
                UTILS.Action.PopupForm(this, new EditForm());
            }
            else
            {
                MessageBox.Show("Could not load book details for editing.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            string keyword = searchtxt.Text.Trim();
            loadBooks(keyword);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void circulationBtn_Click(object sender, EventArgs e)
        {
            UTILS.Action.SwitchForm(this, new CirculationManagement());
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

        private void deletebtn_Click(object sender, EventArgs e)
        {
            if (tableview.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a book to dispose of.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataGridViewRow row = tableview.SelectedRows[0];
            string bookID = row.Cells["BookID"].Value.ToString();
            string bookTitle = row.Cells["BookTitle"].Value.ToString();

            DialogResult result = MessageBox.Show(
                $"Are you sure you want to mark '{bookTitle}' ({bookID}) as DISPOSED? This action cannot be undone.",
                "Confirm Disposal",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.No)
            {
                return;
            }

            DBConnect db = new DBConnect();
            db.Open();

            try
            {
                string updateBookQuery = "UPDATE books SET status = 'DISPOSED' WHERE BookID = @BookID";
                MySqlCommand cmd = new MySqlCommand(updateBookQuery, db.GetConnection());
                cmd.Parameters.AddWithValue("@BookID", bookID);
                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    string updateActiveStatusQuery = @"
                        UPDATE status 
                        SET 
                            status = 'DISPOSED', 
                            Actual_Return_Date = @CurrentDate 
                        WHERE book_id = @BookID 
                        AND (status = 'BORROWED' OR status = 'RESERVED')";

                    MySqlCommand updateStatusCmd = new MySqlCommand(updateActiveStatusQuery, db.GetConnection());
                    updateStatusCmd.Parameters.AddWithValue("@BookID", bookID);
                    updateStatusCmd.Parameters.AddWithValue("@CurrentDate", DateTime.Now.ToString("yyyy-MM-dd"));

                    updateStatusCmd.ExecuteNonQuery();

 
                    MessageBox.Show($"Book '{bookTitle}' has been marked as DISPOSED, and any active circulation records were closed.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadBooks();
                }
                else
                {
                    MessageBox.Show("Failed to update book status. BookID may not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error during disposal: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                db.Close();
            }
        }
    }
}
