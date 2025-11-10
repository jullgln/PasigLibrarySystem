using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
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
            user_data.currentuser = Usernametxtbox.Text.Trim();
            UTILS.Session.CurrentUser = user_data.currentuser;
            string password = passtxtbox.Text.Trim();

            if (user_data.currentuser == "" || password == "")
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

                string query = "SELECT * FROM users WHERE username=@Username AND Password=@Password";
                MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());
                cmd.Parameters.AddWithValue("@Username", user_data.currentuser);
                cmd.Parameters.AddWithValue("@Password", password);

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    user_data.user_id = reader.GetString("User_ID");
                    user_data.email = reader.GetString("email");
                    user_data.real_name = reader.GetString("fullname");
                    string role = reader.GetString("role");
                    MessageBox.Show("Login successful!");

                    if (role == "Admin")
                    {
                        ADMIN.AdminMemberManagement MemManagementForm = new ADMIN.AdminMemberManagement();
                        MemManagementForm.Show();
                        this.Hide();
                    }
                    else
                    {
                        USER.UserDashboard Dashboard = new USER.UserDashboard(UTILS.Session.CurrentUser);
                        Dashboard.Show();
                        this.Hide();
                    }
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
