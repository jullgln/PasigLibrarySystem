using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using PasigLibrarySystem.DATABASES;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PasigLibrarySystem
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.None;
            UIRounder.FormRounder(this, 30);
            H1.ForeColor = UIColors.DarkBlue;
            lbl1.ForeColor = UIColors.DarkBlue;
            lbl2.ForeColor = UIColors.DarkBlue;
            lbl3.ForeColor = UIColors.DarkBlue;
            lbl4.ForeColor = UIColors.DarkBlue;
            UIRounder.RoundBtn(Registerbtn, 20);
            UIRounder.RoundBtn(Cancelbtn, 20);
            Registerbtn.BackColor = UIColors.VividAzure;
            Registerbtn.ForeColor = UIColors.White;
            Cancelbtn.BackColor = UIColors.Crimson;
            Cancelbtn.ForeColor = UIColors.White;
        }

        private void Registerbtn_Click(object sender, EventArgs e)
        {
            //query for registering new user goes here
            string userID = IDGenerator.GenerateUserID();
            string role = "Member";
            string name = nametxtbox.Text.Trim();
            string email = emailtxtbox.Text.Trim();
            string username = Usernametxtbox.Text.Trim();
            string password = passtxtbox.Text.Trim();
            string joined = DateTime.Now.ToString("MM/dd/yyyy");


            if (name == "" || username == "" || password == "")
            {
                MessageBox.Show("Please enter all fields.");
                return;
            }

            DBConnect db = new DBConnect();

            try
            {
                db.Open();

                string query = "INSERT INTO users (User_ID, role, fullname, username, email, Password, date_registered) VALUES (@userid, @role, @Name, @Username, @email, @Password, @datejoined)";
                MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());
                cmd.Parameters.AddWithValue("@userid", userID);
                cmd.Parameters.AddWithValue("@role", role);
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@Password", password);
                cmd.Parameters.AddWithValue("@datejoined", joined);

                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                    MessageBox.Show("Registration successful!");
                else
                    MessageBox.Show("Registration failed.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                db.Close();
            }

            // To go back to LogIn form after registering
            LogIn LogInForm = new LogIn();
            LogInForm.Show();
            this.Hide();
        }

        private void Cancelbtn_Click(object sender, EventArgs e)
        {
            LogIn LogInForm = new LogIn();
            LogInForm.Show();
            this.Hide();
        }
    }
}
