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
    public partial class LostForm : Form
    {
        private string dateBorrowed;
        private decimal fineAmount = 250.00m;
        public LostForm(string dateBorrowed)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            UIRounder.FormRounder(this, 30);
            UIRounder.RoundBtn(Cancelbtn, 20);
            UIRounder.RoundBtn(settleaccbtn, 20);
            Cancelbtn.BackColor = UIColors.Crimson;
            Cancelbtn.ForeColor = UIColors.White;
            settleaccbtn.BackColor = UIColors.DarkBlue;
            settleaccbtn.ForeColor = UIColors.White;

            // Store the date borrowed
            this.dateBorrowed = dateBorrowed;

            titletxt.Text = book_data.currentbookname;
            idtxt.Text = book_data.currentbookid;
            displayname.Text = user_data.real_name;
            borrowdatetxt.Text = dateBorrowed;

            lostdatetxt.Text = DateTime.Now.ToString("yyyy-MM-dd");

            finetxt.Text = fineAmount.ToString("0.00");
        }

        private void Cancelbtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void settleaccbtn_Click(object sender, EventArgs e)
        {
            // Confirmation is highly recommended since this applies a fine and closes the loan.
            DialogResult confirm = MessageBox.Show(
                $"Confirm that book '{book_data.currentbookname}' is LOST. A fine of ₱{fineAmount:0.00} will be applied to the user's account.",
                "Confirm Book Lost", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirm == DialogResult.No)
            {
                return;
            }

            DBConnect db = new DBConnect();
            db.Open();

            string currentBookID = book_data.currentbookid;
            string currentUserID = user_data.user_id;

            MySqlTransaction transaction = db.GetConnection().BeginTransaction();

            try
            {
                string updateStatusQuery = @"
                    UPDATE status 
                    SET 
                        status = 'LOST', 
                        Actual_Return_Date = @LostDate 
                    WHERE book_id = @BookID 
                    AND user_id = @UserID AND status = 'BORROWED'";

                MySqlCommand cmdStatus = new MySqlCommand(updateStatusQuery, db.GetConnection(), transaction);
                cmdStatus.Parameters.AddWithValue("@BookID", currentBookID);
                cmdStatus.Parameters.AddWithValue("@UserID", currentUserID);
                cmdStatus.Parameters.AddWithValue("@LostDate", DateTime.Now.ToString("yyyy-MM-dd"));
                cmdStatus.ExecuteNonQuery();

                string updateBookQuery = "UPDATE books SET status = 'LOST' WHERE BookID = @BookID";
                MySqlCommand cmdBook = new MySqlCommand(updateBookQuery, db.GetConnection(), transaction);
                cmdBook.Parameters.AddWithValue("@BookID", currentBookID);
                cmdBook.ExecuteNonQuery();

                string updateUsersQuery = @"
                    UPDATE users 
                    SET 
                        borrowed_books = borrowed_books - 1, 
                        fines_fees = fines_fees + @FineAmount 
                    WHERE user_id = @UserID";

                MySqlCommand cmdUsers = new MySqlCommand(updateUsersQuery, db.GetConnection(), transaction);
                cmdUsers.Parameters.AddWithValue("@UserID", currentUserID);
                cmdUsers.Parameters.AddWithValue("@FineAmount", fineAmount);
                cmdUsers.ExecuteNonQuery();

                transaction.Commit();

                MessageBox.Show("Book successfully reported LOST and fine applied.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                MessageBox.Show("An error occurred while reporting the book lost: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                db.Close();
            }
        }
    }
}
