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
    public partial class ReserveForm : Form
    {
        public ReserveForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            UIRounder.FormRounder(this, 30);
            UIRounder.RoundBtn(Cancelbtn, 20);
            UIRounder.RoundBtn(reservebtn, 25);
            Cancelbtn.BackColor = UIColors.Crimson;
            Cancelbtn.ForeColor = UIColors.White;
            reservebtn.BackColor = UIColors.VividAzure;
            reservebtn.ForeColor = UIColors.White;
            displaybooktitle.Text = $"{book_data.currentbookname}";
            //lblAuthor.Text = $"Author : {book_data.currentbookauthor}";
            displayborrowdate.Text = $"{DateTime.Now.ToShortDateString()}";
            label1.Text = $"{DateTime.Now.AddDays(7)}";
            displayname.Text = user_data.real_name;
            displaybookid.Text = book_data.currentbookid;
        }

        private void Cancelbtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void reservebtn_Click(object sender, EventArgs e)
        {
            DBConnect db = new DBConnect();
            db.Open();

            // Check book status
            MySqlCommand checkCmd = new MySqlCommand("SELECT Status FROM books WHERE BookID=@bookId", db.GetConnection());
            checkCmd.Parameters.AddWithValue("@bookId", book_data.currentbookid);
            string currentStatus = checkCmd.ExecuteScalar()?.ToString();

            if (string.IsNullOrEmpty(currentStatus))
            {
                MessageBox.Show("Book not found in the database.");
                return;
            }

            //Only allow reservation if book is AVAILABLE or BORROWED
            if (currentStatus.ToUpper() == "RESERVED" || currentStatus.ToUpper() == "BORROWED" || currentStatus.ToUpper() == "AVAILABLE")
            {
                MySqlCommand cmd = new MySqlCommand(
                    $"INSERT INTO status (book_id, journal_id, user_id, status, borrowed_date, return_date, reserved_date) " +
                    $"VALUES (@bookId, NULL, @userId, 'RESERVED', NULL, NULL, @reservedDate)", db.GetConnection());
                cmd.Parameters.AddWithValue("@bookId", book_data.currentbookid);
                cmd.Parameters.AddWithValue("@userId", user_data.user_id);
                cmd.Parameters.AddWithValue("@reservedDate", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                cmd.ExecuteNonQuery();

                if (currentStatus.ToUpper() == "AVAILABLE")
                {
                    MySqlCommand updateBookCmd = new MySqlCommand(
                        $"UPDATE books SET Status='RESERVED' WHERE BookID=@bookId", db.GetConnection());
                    updateBookCmd.Parameters.AddWithValue("@bookId", book_data.currentbookid);
                    updateBookCmd.ExecuteNonQuery();
                }
                MessageBox.Show("Book reserved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("This book cannot be reserved right now.");
            }


            db.Close();
        }
    }
}
