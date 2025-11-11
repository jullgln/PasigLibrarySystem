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
    public partial class UserMyAcc : Form
    {
        public UserMyAcc()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            UIRounder.FormRounder(this, 30);
            highlightpanel.BackColor = UIColors.VividAzure;
            UIRounder.RoundBtn(LogOutbtn, 30);
            LogOutbtn.BackColor = UIColors.White;
            LogOutbtn.ForeColor = UIColors.DarkBlue;
            welcomelbl.Text = "Welcome, " + UTILS.Session.CurrentUser + "!";

        }

        private void Homelbl_Click(object sender, EventArgs e)
        {
            UTILS.Action.SwitchForm(this, new UserDashboard(UTILS.Session.CurrentUser));
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

        private void UserMyAcc_Load(object sender, EventArgs e)
        {
            //DBConnector class
            DBConnect db = new DBConnect();

            db.Open();

            string query = "SELECT fullname, Username, date_registered FROM users WHERE User_ID = @userID";
            MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());
            cmd.Parameters.AddWithValue("@userID", user_data.user_id);

            MySqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                nametxt.Text = reader["fullname"].ToString();
                usernametxt.Text = reader["Username"].ToString();

                if (reader["date_registered"] != DBNull.Value)
                {
                    datejoinedtxt.Text = reader["date_registered"].ToString();
                    ;
                }
                else
                {
                    datejoinedtxt.Text = "N/A";
                }
            }

        }
        private void LoadBorrowedBooks()
        {
            DBConnect db = new DBConnect();
            {
                db.Open();

                // Fetch borrowed books from status + books tables
                MySqlCommand cmd = new MySqlCommand(
                    "SELECT b.BookID, b.BookTitle, b.Author, s.borrowed_date, s.return_date " +
                    "FROM status s " +
                    "JOIN books b ON s.book_id = b.BookID " +
                    "WHERE s.user_id = @borrowerId AND s.status = 'BORROWED'", db.GetConnection());
                cmd.Parameters.AddWithValue("@borrowerId", user_data.user_id);

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                tableview.DataSource = dt;
                tableview.ClearSelection();


                db.Close();
            }
        }
    }
}
