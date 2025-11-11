using Microsoft.VisualBasic;
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
    public partial class ReturnForm : Form
    {
        public ReturnForm(string dateBorrowed, string dateReturn)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            UIRounder.FormRounder(this, 30);
            UIRounder.RoundBtn(returnbtn, 25);
            UIRounder.RoundBtn(Cancelbtn, 20);
            returnbtn.BackColor = UIColors.VividAzure;
            returnbtn.ForeColor = UIColors.White;
            Cancelbtn.BackColor = UIColors.Crimson;
            Cancelbtn.ForeColor = UIColors.White;
            //others
            displayname.Text = user_data.real_name;
            displayemail.Text = user_data.email;
            idtxt.Text = book_data.currentbookid;
            titletxt.Text = book_data.currentbookname;
            borrowdatetxt.Text = DateTime.Now.ToString("MM/dd/yyyy");
            ogreturndatetxt.Text = dateReturn;
        }

        private void settleaccbtn_Click(object sender, EventArgs e)
        {
            //validation
            //change display if there is change
        }

        private void Cancelbtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void returnbtn_Click(object sender, EventArgs e)
        {
            DBConnect db = new DBConnect();
            db.Open();

            try
            {
                DateTime duedate = DateTime.Parse(ogreturndatetxt.Text);
                DateTime actualReturnDate = DateTime.Now;
                double fine = 0;
                double feePerDay = 10; // set fee per day late

                //Calculate fine after due date
                if (actualReturnDate > duedate)
                {
                    int daysLate = (actualReturnDate - duedate).Days;
                    fine = daysLate * feePerDay;
                }

                MySqlCommand updateBook = new MySqlCommand(
                    "UPDATE books SET Status='AVAILABLE' WHERE BookID=@bookId", db.GetConnection());
                updateBook.Parameters.AddWithValue("@bookId", book_data.currentbookid);
                updateBook.ExecuteNonQuery();


                MySqlCommand updateUser = new MySqlCommand(
                    "UPDATE users SET returned_books = returned_books + 1 WHERE user_id=@userId", db.GetConnection());
                updateUser.Parameters.AddWithValue("@userId", user_data.user_id);
                updateUser.ExecuteNonQuery();

                MySqlCommand updateStatus = new MySqlCommand(
                    "UPDATE status SET status='RETURNED', return_date=@returnDate " +
                    "WHERE book_id=@bookId AND user_id=@userId AND status='BORROWED'", db.GetConnection());
                updateStatus.Parameters.AddWithValue("@bookId", book_data.currentbookid);
                updateStatus.Parameters.AddWithValue("@userId", user_data.user_id);
                updateStatus.Parameters.AddWithValue("@returnDate", DateTime.Now.ToString("yyyy-MM-dd"));

                int rowsAffected = updateStatus.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Book returned successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Failed to return the book. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                db.Close();
            }
            Close();
        }
        }
    }