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

namespace PasigLibrarySystem.USER
{
    public partial class UserSettings : Form
    {
        public UserSettings()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            UIRounder.FormRounder(this, 30);
            highlightpanel.BackColor = UIColors.VividAzure;
            UIRounder.RoundBtn(LogOutbtn, 30);
            LogOutbtn.BackColor = UIColors.White;
            LogOutbtn.ForeColor = UIColors.DarkBlue;
            confirmbtn.BackColor = UIColors.VividAzure;
            confirmbtn.ForeColor = UIColors.White;
            cancelbtn.BackColor = UIColors.Crimson;
            cancelbtn.ForeColor = UIColors.White;
            welcomelbl.Text = "Welcome, " + UTILS.Session.CurrentUser + "!";
        }
        private void Homelbl_Click(object sender, EventArgs e)
        {
            UTILS.Action.SwitchForm(this, new UserDashboard(UTILS.Session.CurrentUser));
        }

        private void MyAcclbl_Click(object sender, EventArgs e)
        {
            UTILS.Action.SwitchForm(this, new UserMyAcc());
        }

        private void BookCollectlbl_Click(object sender, EventArgs e)
        {
            UTILS.Action.SwitchForm(this, new UserBookCollection());
        }

        private void Aboutlbl_Click(object sender, EventArgs e)
        {
            UTILS.Action.SwitchForm(this, new UserAbout());
        }

        private void LogOutbtn_Click(object sender, EventArgs e)
        {
            UTILS.Action.LogOut(this, new LogIn());
        }

        private void link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lbl5.Visible = true;
            lbl6.Visible = true;
            newpasstxt.Visible = true;
            confirmnewpasstxt.Visible = true;
        }

        private void UserSettings_Load(object sender, EventArgs e)
        {

            //DBConnector class
            DBConnect db = new DBConnect();

            db.Open();
            string query = "SELECT fullname, username, email, date_registered FROM users WHERE User_ID = @userID";
            MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());
            cmd.Parameters.AddWithValue("@userID", user_data.user_id);

            MySqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                nametxt.Text = reader["fullname"].ToString();
                usernametxt.Text = reader["username"].ToString();
                emailtxt.Text = reader["email"].ToString();
            }
            db.Close();

        }

        private void confirmbtn_Click(object sender, EventArgs e)
        {
            //DBConnector class
            DBConnect db = new DBConnect();

            try
            {
                db.Open();
                string updatecmd = "UPDATE users SET fullname = @name, username = @newUsername, email = @email, Password = @password WHERE User_ID = @userID";
                MySqlCommand cmd = new MySqlCommand(updatecmd, db.GetConnection());
                {
                    cmd.Parameters.AddWithValue("@name", nametxt.Text);
                    cmd.Parameters.AddWithValue("@newUsername", usernametxt.Text);
                    cmd.Parameters.AddWithValue("@email", emailtxt.Text);
                    cmd.Parameters.AddWithValue("@password", confirmnewpasstxt.Text);
                    cmd.Parameters.AddWithValue("@userID", user_data.user_id);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Profile Updated!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!" + ex.Message);
            }
            finally
            {
                db.Close();
            }
        }
    }
}
