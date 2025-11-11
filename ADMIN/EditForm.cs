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

namespace PasigLibrarySystem.ADMIN
{
    public partial class EditForm : Form
    {
        public EditForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            UIRounder.FormRounder(this, 30);
            //for button rounder
            UIRounder.RoundBtn(savebtn, 20);
            UIRounder.RoundBtn(Cancelbtn, 20);
            //for colors
            savebtn.BackColor = UIColors.VividAzure;
            savebtn.ForeColor = UIColors.White;
            Cancelbtn.BackColor = UIColors.Crimson;
            Cancelbtn.ForeColor = UIColors.White;
            LoadExistingData();
        }

        private void Cancelbtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(titletxt.Text) || string.IsNullOrWhiteSpace(authortxt.Text) || string.IsNullOrWhiteSpace(genrecbox.Text))
            {
                MessageBox.Show("Title, Author, and Genre cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DBConnect db = new DBConnect();
            db.Open();

            try
            {
                string updateQuery = @"
                    UPDATE books SET
                        BookTitle = @title,
                        Author = @author,
                        Genre = @genre,
                        Pub_Date = @pubDate,
                        Publisher = @publisher,
                        Pagecount = @pagecount,
                        ISBN = @isbn,
                        Status = @status,
                        Shelf_Number = @shelfNum
                    WHERE BookID = @bookId";

                MySqlCommand cmd = new MySqlCommand(updateQuery, db.GetConnection());

                // 3. Add parameters from form controls
                cmd.Parameters.AddWithValue("@title", titletxt.Text.Trim());
                cmd.Parameters.AddWithValue("@author", authortxt.Text.Trim());
                cmd.Parameters.AddWithValue("@genre", genrecbox.Text.Trim());

                // Assuming PubDateTxt and PageCountTxt require conversion/parsing
                cmd.Parameters.AddWithValue("@pubDate", publishdatetxt.Text.Trim());
                cmd.Parameters.AddWithValue("@publisher", publishertxt.Text.Trim());
                cmd.Parameters.AddWithValue("@pagecount", int.TryParse(pagecounttxt.Text, out int pc) ? pc : 0);

                cmd.Parameters.AddWithValue("@isbn", ISBNtxt.Text.Trim());
                cmd.Parameters.AddWithValue("@status", statuscbox.Text.Trim());
                cmd.Parameters.AddWithValue("@shelfNum", shelfNumtxt.Text.Trim());

                cmd.Parameters.AddWithValue("@bookId", idtxt.Text.Trim());

                // 4. Execute the command
                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Book updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Book details not changed or BookID not found.", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error during update: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                db.Close();
            }
            Close();
        }
        private void LoadExistingData()
        {
            idtxt.Text = book_data.currentbookid;
            titletxt.Text = book_data.currentbookname;
            authortxt.Text = book_data.currentbookauthor;
            genrecbox.Text = book_data.currentgenre;
            publishdatetxt.Text = book_data.currentpublishdate;
            publishertxt.Text = book_data.currentpublisher;
            pagecounttxt.Text = book_data.currentpagecount;
            ISBNtxt.Text = book_data.currentISBN;
            shelfNumtxt.Text = book_data.currentshelfnumber;
            statuscbox.Text = book_data.currentstatus;
            
            string bookTitle = DATABASES.book_data.currentbookname;
            string genre = DATABASES.book_data.currentgenre.ToLower();
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

            abstractxt.Text = summary;
        }
    }
}
