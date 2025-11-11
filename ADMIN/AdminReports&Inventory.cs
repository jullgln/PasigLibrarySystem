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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PasigLibrarySystem.ADMIN
{
    public partial class AdminReports_Inventory : Form
    {
        public AdminReports_Inventory()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            UIRounder.FormRounder(this, 30);
            highlightpanel.BackColor = UIColors.VividAzure;
            UIRounder.RoundBtn(LogOutbtn, 30);
            LogOutbtn.BackColor = UIColors.White;
            LogOutbtn.ForeColor = UIColors.DarkBlue;

        }
        private void LoadBookReport()
        {
            try
            {
                DBConnect db = new DBConnect();
                db.Open();

                // 📘 Book activity data
                string activityQuery = @"
            SELECT 
                s.book_id AS BookID,
                b.BookTitle,
                s.user_id AS UserID,
                s.status AS Status,
                s.borrowed_date AS BorrowedDate,
                s.return_date AS ReturnDate,
                s.Actual_Return_Date AS ActualReturnDate
            FROM status s
            JOIN books b ON s.book_id = b.BookID
            WHERE s.status IN ('BORROWED', 'RETURNED', 'LOST')";

                MySqlDataAdapter daActivity = new MySqlDataAdapter(activityQuery, db.GetConnection());
                DataTable dtActivity = new DataTable();
                daActivity.Fill(dtActivity);

                tableview.DataSource = dtActivity;
                tableview.ClearSelection();

                // 📊 Build the summary text
                string summaryText = "📚 Most Read Books:\r\n";

                // 🔹 Most-read books query
                string popularQuery = @"
            SELECT b.BookTitle, COUNT(*) AS TimesBorrowed
            FROM status s
            JOIN books b ON s.book_id = b.BookID
            WHERE s.status IN ('BORROWED', 'RETURNED')
            GROUP BY b.BookTitle
            ORDER BY TimesBorrowed DESC
            LIMIT 5";

                MySqlCommand cmdPopular = new MySqlCommand(popularQuery, db.GetConnection());
                using (MySqlDataReader reader = cmdPopular.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        summaryText += $"• {reader["BookTitle"]} — {reader["TimesBorrowed"]} times\r\n";
                    }
                } // ✅ closes reader

                // 🔹 Genre breakdown
                summaryText += "\r\n🏷️ Genre Breakdown:\r\n";
                string genreQuery = "SELECT Genre, COUNT(*) AS Count FROM books GROUP BY Genre";

                MySqlCommand cmdGenre = new MySqlCommand(genreQuery, db.GetConnection());
                using (MySqlDataReader reader = cmdGenre.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        summaryText += $"• {reader["Genre"]}: {reader["Count"]} books\r\n";
                    }
                }

                abstractxt.Text = summaryText;

                db.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading the book report: " + ex.Message,
                                "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadInventoryReport()
        {
            try
            {
                DBConnect db = new DBConnect();
                db.Open();

                // 📘 Grid data
                string query = @"
            SELECT 
                BookID,
                BookTitle,
                Author,
                Genre,
                Pub_Date,
                Pagecount,
                Publisher,
                Language,
                ISBN,
                status,
                Shelf_Number
            FROM books";

                MySqlDataAdapter da = new MySqlDataAdapter(query, db.GetConnection());
                DataTable dt = new DataTable();
                da.Fill(dt);

                tableview.DataSource = dt;
                tableview.ClearSelection();

                // 📊 Summary
                MySqlCommand cmdTotalBooks = new MySqlCommand("SELECT COUNT(*) FROM books", db.GetConnection());
                int totalBooks = Convert.ToInt32(cmdTotalBooks.ExecuteScalar());

                MySqlCommand cmdFines = new MySqlCommand("SELECT COUNT(*) FROM users WHERE fines_fees > 0", db.GetConnection());
                int fines = Convert.ToInt32(cmdFines.ExecuteScalar());

                string summaryText = "📦 Book Inventory Summary:\r\n\r\n";
                summaryText += $"Total Books in Library: {totalBooks}\r\n";
                summaryText += $"Total Users with Fines: {fines}\r\n";

                abstractxt.Text = summaryText;

                db.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading the inventory report: " + ex.Message,
                                "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LogOutbtn_Click(object sender, EventArgs e)
        {
            UTILS.Action.LogOut(this, new LogIn());
        }

        private void memberlbl_Click(object sender, EventArgs e)
        {
            UTILS.Action.SwitchForm(this, new AdminMemberManagement());
        }

        private void BookManagelbl_Click(object sender, EventArgs e)
        {
            UTILS.Action.SwitchForm(this, new AdminBookManagement());
        }

        private void filtertxt_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = filtertxt.Text.Trim();

            if (selected == "Book Reports")
            {
                LoadBookReport();
                tableview.Visible = true;
                abstractxt.Visible = true;
            }
            else if (selected == "Book Inventory")
            {
                LoadInventoryReport();

                tableview.Visible = true;
                abstractxt.Visible = true;
            }
        }
    }
}
