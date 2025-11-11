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
    public partial class AddBookForm : Form
    {
        public AddBookForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            UIRounder.FormRounder(this, 30);
            //for button rounder
            UIRounder.RoundBtn(addbookbtn, 20);
            UIRounder.RoundBtn(Cancelbtn, 20);
            //for colors
            addbookbtn.BackColor = UIColors.VividAzure;
            addbookbtn.ForeColor = UIColors.White;
            Cancelbtn.BackColor = UIColors.Crimson;
            Cancelbtn.ForeColor = UIColors.White;
        }

        private void Cancelbtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void addbookbtn_Click(object sender, EventArgs e)
        {
            string bookid = IDGenerator.GeneratebookID();
            string isbn = IDGenerator.GenerateISBN();
            string shelf = IDGenerator.GenerateShelfNumber();
            string title = titletxt.Text;
            string author = authortxt.Text;
            string genre = genrecbox.Text;
            string language = txtlang.Text;
            int pubYear = int.Parse(publishdatetxt.Text);
            int page = int.Parse(pagecounttxt.Text);
            string publishers = publishertxt.Text;
            string status = statustxt.Text;


            DBConnect db = new DBConnect();
            {
                db.Open();
                MySqlCommand cmd = new MySqlCommand($"INSERT INTO books (BookID, BookTitle, Author, Genre, Pub_Date, pagecount, publisher, language, ISBN, Shelf_Number, status) " +
                               $"VALUES (@id, @title, @author, @genre, @pubYear, @pages, @publisher, @lang, @isbn, @shelf, @status)", db.GetConnection());
                cmd.Parameters.AddWithValue("id", bookid);
                cmd.Parameters.AddWithValue("@title", title);
                cmd.Parameters.AddWithValue("@author", author);
                cmd.Parameters.AddWithValue("@genre", genre);
                cmd.Parameters.AddWithValue("@pubYear", pubYear);
                cmd.Parameters.AddWithValue("@pages", page);
                cmd.Parameters.AddWithValue("@publisher", publishers);
                cmd.Parameters.AddWithValue("@lang", language);
                cmd.Parameters.AddWithValue("@isbn", isbn);
                cmd.Parameters.AddWithValue("@shelf", shelf);
                cmd.Parameters.AddWithValue("@status", status);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Book added successfully!");
                this.Hide();
                Close();
            }
        }
    }
}
