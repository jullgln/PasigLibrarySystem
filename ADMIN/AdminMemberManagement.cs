using MySql.Data.MySqlClient;
using PasigLibrarySystem.DATABASES;
using System.Data;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PasigLibrarySystem.ADMIN
{
    public partial class AdminMemberManagement : Form
    {
        public AdminMemberManagement()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            UIRounder.FormRounder(this, 30);
            highlightpanel.BackColor = UIColors.VividAzure;
            UIRounder.RoundBtn(LogOutbtn, 30);
            LogOutbtn.BackColor = UIColors.White;
            LogOutbtn.ForeColor = UIColors.DarkBlue;
            searchbtn.ForeColor = UIColors.White;
            searchbtn.BackColor = UIColors.VividAzure;
            addadminbtn.ForeColor = UIColors.White;
            addadminbtn.BackColor = UIColors.DarkBlue;
            welcomelbl.Text = "Welcome, " + UTILS.Session.CurrentUser + "!";
            loadUsers("");
        }
        private void loadUsers(string searchTerm)
        {
            try
            {
                string query = "SELECT user_id, role, username, email, fullname, date_registered, borrowed_books, returned_books, fines_fees FROM users";
                if (!string.IsNullOrEmpty(searchTerm))
                {
                    query += " WHERE user_id LIKE @search OR " +
                             "username LIKE @search OR " +
                             "fullname LIKE @search OR " +
                             "email LIKE @search";
                }

                DBConnect db = new DBConnect();

                db.Open();
                MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());
                if (!string.IsNullOrEmpty(searchTerm))
                {
                    cmd.Parameters.AddWithValue("@search", "%" + searchTerm + "%");
                }
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                da.Fill(dt);

                tableview.DataSource = dt;
                tableview.ClearSelection();

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured while loading user data: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void loadUsersByRole(string roleFilter)
        {
            try
            {
                string query = "SELECT user_id, role, username, email, fullname, date_registered, borrowed_books, returned_books, fines_fees FROM users";

                // Add WHERE condition only if filtering
                if (roleFilter == "Admin")
                {
                    query += " WHERE role = 'Admin'";
                }
                else if (roleFilter == "Member")
                {
                    query += " WHERE role = 'Member'";
                }

                DBConnect db = new DBConnect();
                db.Open();

                MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                tableview.DataSource = dt;
                tableview.ClearSelection();

                db.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading user data: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LogOutbtn_Click(object sender, EventArgs e)
        {
            UTILS.Action.LogOut(this, new LogIn());
        }

        private void BookManagelbl_Click(object sender, EventArgs e)
        {
            UTILS.Action.SwitchForm(this, new AdminBookManagement());
        }

        private void rep_invlbl_Click(object sender, EventArgs e)
        {
            UTILS.Action.SwitchForm(this, new AdminReports_Inventory());


        }

        private void addadminbtn_Click(object sender, EventArgs e)
        {
            UTILS.Action.PopupForm(this, new AddAdmin());
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            loadUsers(searchtxt.Text.Trim());
            searchtxt.Clear();
        }

        private void filtertxt_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedRole = filtertxt.SelectedItem?.ToString();
            loadUsersByRole(selectedRole);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            UTILS.Action.SwitchForm(this, new AdminCirculationManagement());
        }
    }
}
