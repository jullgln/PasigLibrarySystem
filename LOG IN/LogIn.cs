using MySql.Data.MySqlClient;
using PasigLibrarySystem.DATABASES;
using PasigLibrarySystem.LOG_IN;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasigLibrarySystem
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            UIRounder.FormRounder(this, 30);
            H1.ForeColor = UIColors.DarkBlue;
            lbl1.ForeColor = UIColors.DarkBlue;
            lbl2.ForeColor = UIColors.DarkBlue;
            lbl3.ForeColor = UIColors.DarkBlue;
            link1.ForeColor = UIColors.DarkBlue;
            UIRounder.RoundBtn(LogInbtn, 20);
            LogInbtn.BackColor = UIColors.VividAzure;
            LogInbtn.ForeColor = UIColors.White;
            exitbtn.ForeColor = UIColors.DarkBlue;
            mnmzbtn.ForeColor = UIColors.DarkBlue;
        }
        private void link1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgotPass ForgotPassForm = new ForgotPass();
            ForgotPassForm.Show();
            this.Hide();
        }
        private void link2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUp signUpForm = new SignUp();
            signUpForm.Show();
            this.Hide();
        }

        private void LogInbtn_Click(object sender, EventArgs e)
        {
            string username = Usernametxtbox.Text.Trim();
            string password = passtxtbox.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                inc.ForeColor = UIColors.Crimson;
                inc.Text = "Please enter username and password";
                inc1.Text = "";
                return;
            }
            //DBConnector class
            DBConnect db = new DBConnect();

            try
            {
                db.Open();

                string query = "SELECT * FROM users WHERE  username=@Username AND password=@Password";
                MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", password);

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    USER.UserDashboard Dashboard = new USER.UserDashboard();
                    Dashboard.Show();
                    this.Hide();
                }
                else
                {
                    inc1.ForeColor = UIColors.Crimson;
                    inc1.Text = "Invalid username or password";
                    inc.Text = "";
                    Usernametxtbox.Clear();
                    passtxtbox.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
            finally
            {
                db.Close();
            }
        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnmzbtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
