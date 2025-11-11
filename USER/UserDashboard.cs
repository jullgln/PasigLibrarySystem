using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasigLibrarySystem.USER
{

    public partial class UserDashboard : Form
    {
        public UserDashboard(string currentUser)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            //for button rounder
            UIRounder.FormRounder(this, 30);
            UIRounder.RoundBtn(LogOutbtn, 30);
            //for colors
            highlightpanel.BackColor = UIColors.VividAzure;
            LogOutbtn.BackColor = UIColors.White;
            LogOutbtn.ForeColor = UIColors.DarkBlue;
            borrowbtn.BackColor = UIColors.VividAzure;
            borrowbtn.ForeColor = UIColors.White;
            reservebtn.BackColor = UIColors.VividAzure;
            reservebtn.ForeColor = UIColors.White;
            ViewDetails.BackColor = UIColors.VividAzure;
            ViewDetails.ForeColor = UIColors.White;
            //others
            welcomelbl.Text = "Welcome, " + UTILS.Session.CurrentUser + "!";
        }

        private void MyAcclbl_Click(object sender, EventArgs e)
        {
            UTILS.Action.SwitchForm(this, new UserMyAcc());
        }

        private void BookCollectlbl_Click(object sender, EventArgs e)
        {
            UTILS.Action.SwitchForm(this, new UserBookCollection());
        }

        private void Aboutlbl_Click(object sender, EventArgs e)
        {
            UTILS.Action.SwitchForm(this, new UserAbout());
        }

        private void Settingslbl_Click(object sender, EventArgs e)
        {
            UTILS.Action.SwitchForm(this, new UserSettings());
        }
        private void LogOutbtn_Click(object sender, EventArgs e)
        {
            UTILS.Action.LogOut(this, new LogIn());
        }

        private void borrowbtn_Click(object sender, EventArgs e)
        {
            UTILS.Action.PopupForm(this, new BorrowForm());
        }

        private void reservebtn_Click(object sender, EventArgs e)
        {
            UTILS.Action.PopupForm(this, new ReserveForm());
        }

        private void ViewDetails_Click(object sender, EventArgs e)
        {
            UTILS.Action.PopupForm(this, new ViewDetails());
        }

        private void search_Click(object sender, EventArgs e)
        {
            lbl2.Text = "Based on Search:";
        }
    }
}
