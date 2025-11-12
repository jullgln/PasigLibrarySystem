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
    public partial class BorrowForm : Form
    {
        public BorrowForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            //for button rounder
            UIRounder.FormRounder(this, 30);
            UIRounder.RoundBtn(borrowbtn, 25);
            UIRounder.RoundBtn(Cancelbtn, 20);
            //for colors
            borrowbtn.BackColor = UIColors.VividAzure;
            borrowbtn.ForeColor = UIColors.White;
            Cancelbtn.BackColor = UIColors.Crimson;
            Cancelbtn.ForeColor = UIColors.White;
            //others
            displayname.Text = user_data.real_name;
            displayemail.Text = user_data.email;    
            idtxt.Text = book_data.currentbookid;
            titletxt.Text = book_data.currentbookname;
            authortxt.Text = book_data.currentbookauthor;
            borrowdatetxt.Text = DateTime.Now.ToString("MM/dd/yyyy");
            datepicker.Value = DateTime.Now.AddDays(7);

        }

        private void Cancelbtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void borrowbtn_Click(object sender, EventArgs e)
        {
            DBConnect db = new DBConnect();
            db.Open();

            //Check book status
            MySqlCommand checkCmd = new MySqlCommand(
                "SELECT Status FROM books WHERE ID=@bookId", db.GetConnection());
            checkCmd.Parameters.AddWithValue("@bookId", book_data.currentbookid);
            string currentStatus = checkCmd.ExecuteScalar()?.ToString();

            if (string.IsNullOrEmpty(currentStatus))
            {
                MessageBox.Show("Book not found in the database.");
                db.Close();
                return;
            }

            string statusUpper = currentStatus.ToUpper();

            // Check if user can borrow
            bool canBorrow = false;

            if (statusUpper == "AVAILABLE")
            {
                canBorrow = true;
            }
            else if (statusUpper == "RESERVED")
            {
                MySqlCommand checkQueue = new MySqlCommand(
                    "SELECT user_id FROM status WHERE ID=@bookId AND status='RESERVED' ORDER BY reserved_date LIMIT 1",
                    db.GetConnection());
                checkQueue.Parameters.AddWithValue("@bookId", book_data.currentbookid);

                string firstInQueueStr = checkQueue.ExecuteScalar()?.ToString();
                int firstInQueueId = 0;

                if (!string.IsNullOrEmpty(firstInQueueStr))
                {
                    firstInQueueId = Convert.ToInt32(firstInQueueStr);
                }

                if (firstInQueueId == Convert.ToInt32(user_data.user_id))
                    canBorrow = true;
            }

            if (!canBorrow)
            {
                MessageBox.Show("This book is currently not available for you to borrow.");
                db.Close();
                return;
            }

            //Insert borrow record 
            MySqlCommand cmd = new MySqlCommand(
                "INSERT INTO status (ID, user_id, status, borrowed_date, return_date, reserved_date) " +
                "VALUES (@bookID, @userId, 'BORROWED', @borrowedDate, @returnDate, NULL)", db.GetConnection());
            cmd.Parameters.AddWithValue("@bookId", book_data.currentbookid);
            cmd.Parameters.AddWithValue("@userId", user_data.user_id);
            cmd.Parameters.AddWithValue("@borrowedDate", DateTime.Now.ToString("MM/dd/yyyy"));
            cmd.Parameters.AddWithValue("@returnDate", DateTime.Now.AddDays(7).ToString("MM/dd/yyyy"));
            cmd.ExecuteNonQuery();

            //Update book table status
            MySqlCommand updateBookCmd = new MySqlCommand(
                "UPDATE books SET Status='BORROWED' WHERE ID=@bookId", db.GetConnection());
            updateBookCmd.Parameters.AddWithValue("@bookId", book_data.currentbookid);
            updateBookCmd.ExecuteNonQuery();

            MySqlCommand updateCountCmd = new MySqlCommand(
                "UPDATE users SET borrowed_books = borrowed_books + 1 WHERE user_id=@userId",
                db.GetConnection());
            updateCountCmd.Parameters.AddWithValue("@userId", user_data.user_id);
            updateCountCmd.ExecuteNonQuery();

            MessageBox.Show("Book borrowed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            db.Close();
            this.Close();
        }
    }
}
