using Microsoft.VisualBasic.Devices;
using MySql.Data.MySqlClient;
using PasigLibrarySystem.DATABASES;
using PasigLibrarySystem.USER;
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
    public partial class AdminBookManagement : Form
    {
        public AdminBookManagement()
        {
            InitializeComponent();
            loadBooks();
            this.FormBorderStyle = FormBorderStyle.None;
            UIRounder.FormRounder(this, 30);
            highlightpanel.BackColor = UIColors.VividAzure;
            UIRounder.RoundBtn(LogOutbtn, 30);
            LogOutbtn.BackColor = UIColors.White;
            LogOutbtn.ForeColor = UIColors.DarkBlue;
            addbtn.ForeColor = UIColors.White;
            addbtn.BackColor = UIColors.VividAzure;
            viewdetailsbtn.ForeColor = UIColors.White;
            viewdetailsbtn.BackColor = UIColors.VividAzure;
            editbtn.ForeColor = UIColors.White;
            editbtn.BackColor = UIColors.VividAzure;
            deletebtn.ForeColor = UIColors.White;
            deletebtn.BackColor = UIColors.VividAzure;
            searchbtn.ForeColor = UIColors.White;
            searchbtn.BackColor = UIColors.VividAzure;
        }
        private void loadBooks(string keyword = "", string category = "All")
        {
            DBConnect db = new DBConnect();
            {
                db.Open();
                string sql = $"SELECT b.BookID, b.BookTitle, b.Author, b.Genre, b.Pub_Date, b.status " +
                         $"FROM books b";

                if (!string.IsNullOrEmpty(keyword))
                {
                    if (category == "All")
                    {
                        sql += " WHERE b.BookTitle LIKE @keyword OR b.Author LIKE @keyword OR b.Genre LIKE @keyword";
                    }
                    else if (category == "Title")
                    {
                        sql += " WHERE b.BookTitle LIKE @keyword";
                    }
                    else if (category == "Author")
                    {
                        sql += " WHERE b.Author LIKE @keyword";
                    }
                    else if (category == "Genre")
                    {
                        sql += " WHERE b.Genre LIKE @keyword";
                    }
                }
                MySqlCommand cmd = new MySqlCommand(sql, db.GetConnection());

                if (!string.IsNullOrEmpty(keyword))
                {
                    cmd.Parameters.AddWithValue("@keyword", "%" + keyword + "%");
                }

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                MySqlCommand command = new MySqlCommand("SELECT * FROM books", db.GetConnection());
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dz = new DataTable();
                da.Fill(dz);
                tableview.DataSource = dz;
                tableview.ClearSelection();
                db.Close();
            }
        }
        private void LogOutbtn_Click(object sender, EventArgs e)
        {
            UTILS.Action.LogOut(this, new LogIn());
        }

        private void rep_invlbl_Click(object sender, EventArgs e)
        {
            UTILS.Action.SwitchForm(this, new AdminReports_Inventory());
        }
        private void memberlbl_Click(object sender, EventArgs e)
        {
            UTILS.Action.SwitchForm(this, new AdminMemberManagement());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            UTILS.Action.PopupForm(this, new ViewDetails());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UTILS.Action.PopupForm(this, new AddBookForm());
        }

        private void editbtn_Click(object sender, EventArgs e)
        {
            UTILS.Action.PopupForm(this, new EditForm());

        }

        private void searchbtn_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
