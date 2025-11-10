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
    public partial class UserBookCollection : Form
    {
        public UserBookCollection()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            // for button rounder
            UIRounder.FormRounder(this, 30);
            UIRounder.RoundBtn(LogOutbtn, 30);
            // for colors
            LogOutbtn.BackColor = UIColors.White;
            LogOutbtn.ForeColor = UIColors.DarkBlue;
            lostbtn.BackColor = UIColors.VividAzure;
            lostbtn.ForeColor = UIColors.White;
            returnbtn.BackColor = UIColors.VividAzure;
            returnbtn.ForeColor = UIColors.White;
            searchbtn.BackColor = UIColors.VividAzure;
            searchbtn.ForeColor = UIColors.White;
            highlightpanel.BackColor = UIColors.VividAzure;
            // others
            welcomelbl.Text = "Welcome, " + UTILS.Session.CurrentUser + "!";
        }

        private void Homelbl_Click(object sender, EventArgs e)
        {
            UTILS.Action.SwitchForm(this, new UserDashboard(UTILS.Session.CurrentUser));
        }

        private void MyAcclbl_Click(object sender, EventArgs e)
        {
            UTILS.Action.SwitchForm(this, new UserMyAcc());
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

        private void lostbtn_Click(object sender, EventArgs e)
        {
            UTILS.Action.PopupForm(this, new LostForm());
        }

        private void returnbtn_Click(object sender, EventArgs e)
        {
            UTILS.Action.PopupForm(this, new ReturnForm());
        }
    }
}
