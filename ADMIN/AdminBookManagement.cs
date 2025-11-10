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
    }
}
