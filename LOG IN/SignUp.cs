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
            Registerbtn.BackColor = UIColors.VividAzure;
            Registerbtn.ForeColor = UIColors.White;
        }

        private void Registerbtn_Click(object sender, EventArgs e)
        {
            //query for registering new user goes here
            string userID = IDGenerator.GenerateUserID();
            string name = nametxtbox.Text.Trim();
            string email = emailtxtbox.Text.Trim();
            string username = Usernametxtbox.Text.Trim();
            string password = passtxtbox.Text.Trim();
            DateTime joined = DateTime.Now;

            if (name == "" || username == "" || password == "")
            {
                MessageBox.Show("Please enter all fields.");
                return;
            }

            DBConnect db = new DBConnect();

            try
            {
                db.Open();

                string query = "INSERT INTO users (user_id, fullname, username, Email, password, date_registered) " +
                               "VALUES (@userID, @name, @username, @email, @password, @joined)";
                MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());

                cmd.Parameters.AddWithValue("@userID", userID);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@joined", joined);

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
    }
}
