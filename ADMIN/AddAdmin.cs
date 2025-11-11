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
using System.Xml.Linq;

namespace PasigLibrarySystem.ADMIN
{
    public partial class AddAdmin : Form
    {
        public AddAdmin()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            UIRounder.FormRounder(this, 30);
            UIRounder.RoundBtn(register, 20);
            UIRounder.RoundBtn(Cancelbtn, 20);
            register.BackColor = UIColors.VividAzure;
            register.ForeColor = UIColors.White;
            Cancelbtn.BackColor = UIColors.Crimson;
            Cancelbtn.ForeColor = UIColors.White;
            string generatedUserID = IDGenerator.GenerateUserID();
            idtxt.Text = generatedUserID;
        }

        private void Cancelbtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void register_Click(object sender, EventArgs e)
        {
            string userID = IDGenerator.GenerateUserID();
            string username = usernametxt.Text.Trim();
            string name = nametxt.Text.Trim();
            string email = emailtxt.Text.Trim();
            string password = passtxt.Text.Trim();
            string role = "Admin";
            string joined = DateTime.Now.ToString("MM/dd/yyyy");

            if (username == "" || name == "" || email == "" || password == "")
            {
                MessageBox.Show("Please fill in all fields.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                DBConnect db = new DBConnect();
                db.Open();

                string query = "INSERT INTO users (user_id, role, fullname, username, email, password, date_registered) VALUES (@userid, @role, @Name, @Username, @Email, @Password, @DateJoined)";
                MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());
                cmd.Parameters.AddWithValue("@userid", userID);
                cmd.Parameters.AddWithValue("@role", role);
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@Password", password);
                cmd.Parameters.AddWithValue("@datejoined", joined);

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Admin added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close(); // Close the AddAdmin form
                }
                else
                {
                    MessageBox.Show("Failed to add admin.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                db.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while adding the admin: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
