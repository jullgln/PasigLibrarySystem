using MySql.Data.MySqlClient;
using PasigLibrarySystem.DATABASES;
using System;
using System.Collections;
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
    public partial class UserBookCollection : Form
    {
        public UserBookCollection()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            // for button rounder
            UIRounder.FormRounder(this, 30);
            UIRounder.RoundBtn(LogOutbtn, 30);
            // for colors
            LogOutbtn.BackColor = UIColors.White;
            LogOutbtn.ForeColor = UIColors.DarkBlue;
            lostbtn.BackColor = UIColors.VividAzure;
            lostbtn.ForeColor = UIColors.White;
            returnbtn.BackColor = UIColors.VividAzure;
            returnbtn.ForeColor = UIColors.White;
            searchbtn.BackColor = UIColors.VividAzure;
            searchbtn.ForeColor = UIColors.White;
            highlightpanel.BackColor = UIColors.VividAzure;
            // others
            welcomelbl.Text = "Welcome, " + UTILS.Session.CurrentUser + "!";
        }
        private void LoadBookCounts()
        {
            DBConnect db = new DBConnect();

            db.Open();

            int returnedBooks = 0;

            string getUserQuery = "SELECT returned_books FROM users WHERE user_id=@userid";
            MySqlCommand cmd = new MySqlCommand(getUserQuery, db.GetConnection());

            cmd.Parameters.AddWithValue("@userid", user_data.user_id);
            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {

                    returnedBooks = Convert.ToInt32(reader["returned_books"]);

                }
                else
                {
                    borrowno.Text = "0";
                    returnno.Text = "0";
                    reader.Close();
                    return;
                }
            }


            string borrowedQuery = "SELECT borrowed_books FROM users WHERE user_id=@id";
            MySqlCommand cmd1 = new MySqlCommand(borrowedQuery, db.GetConnection());

            cmd1.Parameters.AddWithValue("@id", user_data.user_id);
            int borrowedCount = Convert.ToInt32(cmd1.ExecuteScalar());
            
            borrowno.Text = borrowedCount.ToString();
            returnno.Text = returnedBooks.ToString();

            db.Close();
        }


        private void Homelbl_Click(object sender, EventArgs e)
        {
            UTILS.Action.SwitchForm(this, new UserDashboard(UTILS.Session.CurrentUser));
        }

        private void MyAcclbl_Click(object sender, EventArgs e)
        {
            UTILS.Action.SwitchForm(this, new UserMyAcc());
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

        private void lostbtn_Click(object sender, EventArgs e)
        {
            UTILS.Action.PopupForm(this, new LostForm());
        }

        private void returnbtn_Click(object sender, EventArgs e)
        {
            string dateBorrowed = "";
            string dateReturn = "";

            DBConnect db = new DBConnect();

            try
            {
                db.Open();
                string query = "SELECT borrowed_date, return_date FROM status WHERE user_ID = @userID";
                MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());
                cmd.Parameters.AddWithValue("@userID", UTILS.Session.CurrentUser);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        dateBorrowed = reader["borrowed_date"].ToString();
                        dateReturn = reader["return_date"].ToString();
                    }
                }
            }
            finally
            {
                db.Close();
            }

            ReturnForm form = new ReturnForm(dateBorrowed, dateReturn);
            form.Show();
        }

        private void UserBookCollection_Load(object sender, EventArgs e)
        {
            LoadBookCounts();

        }
    }
}
