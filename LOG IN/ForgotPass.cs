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
using static System.Windows.Forms.LinkLabel;

namespace PasigLibrarySystem.LOG_IN
{
    public partial class ForgotPass : Form
    {
        public ForgotPass()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            UIRounder.FormRounder(this, 30);
            H1.ForeColor = UIColors.DarkBlue;
            lbl1.ForeColor = UIColors.DarkBlue;
            lbl2.ForeColor = UIColors.DarkBlue;
            lbl3.ForeColor = UIColors.DarkBlue;
            UIRounder.RoundBtn(Resetbtn, 20);
            UIRounder.RoundBtn(Cancelbtn, 20);
            Resetbtn.BackColor = UIColors.VividAzure;
            Resetbtn.ForeColor = UIColors.White;
            Cancelbtn.BackColor = UIColors.Crimson;
            Cancelbtn.ForeColor = UIColors.White;
        }

        private void Resetbtn_Click(object sender, EventArgs e)
        {
            string user = Usernametxtbox.Text.Trim();
            string newpass = NewPasstxtbox.Text.Trim();
            string confirmpass = CNewPasstxtbox.Text.Trim();

            if (user == "")
            {
                MessageBox.Show("Enter username");
                return;
            }
            if (newpass == "")
            {
                MessageBox.Show("Enter new password");
                return;
            }
            if (confirmpass == "")
            {
                MessageBox.Show("Confirm your password");
                return;
            }
            if (newpass != confirmpass)
            {
                MessageBox.Show("Password not match");
                return;
            }
            //DBConnector class
            DBConnect db = new DBConnect();
            try
            {
                db.Open();
                string check = "SELECT COUNT(*) FROM users WHERE Username=@user";
                MySqlCommand cmd = new MySqlCommand(check, db.GetConnection());
                cmd.Parameters.AddWithValue("@user", user);
                int count = Convert.ToInt32(cmd.ExecuteScalar());

                if (count > 0)
                {
                    string update = "UPDATE users SET Password=@pass WHERE Username=@user";
                    MySqlCommand upcmd = new MySqlCommand(update, db.GetConnection());
                    upcmd.Parameters.AddWithValue("@pass", newpass);
                    upcmd.Parameters.AddWithValue("@user", user);
                    upcmd.ExecuteNonQuery();

                    MessageBox.Show("Password changed!");
                    LogIn LogInForm = new LogIn();
                    LogInForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Username not found");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void Cancelbtn_Click(object sender, EventArgs e)
        {
            LogIn LogInForm = new LogIn();
            LogInForm.Show();
            this.Hide();
        }
    }
}
