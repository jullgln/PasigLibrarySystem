using Google.Protobuf.Reflection;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
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

namespace PasigLibrarySystem.ADMIN
{
    public partial class AdminCirculationManagement : Form
    {
        public AdminCirculationManagement()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            UIRounder.FormRounder(this, 30);
            highlightpanel.BackColor = UIColors.VividAzure;
            UIRounder.RoundBtn(LogOutbtn, 30);
            LogOutbtn.BackColor = UIColors.White;
            LogOutbtn.ForeColor = UIColors.DarkBlue;
            welcomelbl.Text = "Welcome, " + UTILS.Session.CurrentUser + "!";
            cbxFilter.SelectedIndex = 0;
        }

        private void AdminCirculationManagement_Load(object sender, EventArgs e)
        {

        }
        private void LoadCirculationData()
        {
            string selectedStatus = cbxFilter.SelectedItem?.ToString();
            string statusCirculation = "%";

            if (selectedStatus != null && !selectedStatus.StartsWith("ALL", StringComparison.OrdinalIgnoreCase))
            {
                statusCirculation = selectedStatus;
            }
            string sqlQuery = @"
                    SELECT
                        s.StatusID AS 'Transaction ID',
                        s.status AS 'Current Status',
                        s.borrowed_date AS 'Borrowed Date',
                        s.return_date AS 'Due Date',
                        s.Actual_Return_Date AS 'Actual Return Date',
                        u.user_id AS 'User ID',
                        u.fullname AS 'Borrower Name',
                        u.fines_fees AS 'Total Fines (₱)',
                        s.ID AS 'Item ID',
                        b.type AS 'Item Type',
                        b.Title AS 'Title'
                    FROM
                        status s
                    LEFT JOIN
                        users u ON UPPER(s.user_id) = UPPER(u.user_id)
                    LEFT JOIN
                        books b ON UPPER(s.ID) = UPPER(b.ID)";

            if (selectedStatus != null && selectedStatus.StartsWith("ALL", StringComparison.OrdinalIgnoreCase))
            {
                sqlQuery += " WHERE s.status NOT LIKE 'DISPOSED'";
            }
            else
            {
                sqlQuery += " WHERE s.status LIKE @StatusFilter";
            }

            sqlQuery += @"
            ORDER BY
            s.return_date ASC";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(DATABASES.DBConnect.connectionString))
                {
                    connection.Open();
                    MySqlCommand command = new MySqlCommand(sqlQuery, connection);
                    if (selectedStatus != null && selectedStatus.StartsWith("ALL", StringComparison.OrdinalIgnoreCase))
                    {

                    }
                    else
                    {
                        command.Parameters.AddWithValue("@StatusFilter", statusCirculation);
                    }

                    MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    dataGridView1.DataSource = dataTable;
                    dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading circulation data: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbxFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadCirculationData();
        }

        private void LogOutbtn_Click(object sender, EventArgs e)
        {
            UTILS.Action.LogOut(this, new LogIn());
        }

        private void memberlbl_Click(object sender, EventArgs e)
        {
            UTILS.Action.SwitchForm(this, new AdminMemberManagement());

        }

        private void BookManagelbl_Click(object sender, EventArgs e)
        {
            UTILS.Action.SwitchForm(this, new AdminBookManagement());

        }

        private void rep_invlbl_Click(object sender, EventArgs e)
        {
            UTILS.Action.SwitchForm(this, new AdminReports_Inventory());

        }
    }
}
