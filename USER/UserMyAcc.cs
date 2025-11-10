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
    public partial class UserMyAcc : Form
    {
        public UserMyAcc()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            UIRounder.FormRounder(this, 30);
            highlightpanel.BackColor = UIColors.VividAzure;
            UIRounder.RoundBtn(LogOutbtn, 30);
            LogOutbtn.BackColor = UIColors.White;
            LogOutbtn.ForeColor = UIColors.DarkBlue;
            welcomelbl.Text = "Welcome, " + UTILS.Session.CurrentUser + "!";

        }

        private void Homelbl_Click(object sender, EventArgs e)
        {
            UTILS.Action.SwitchForm(this, new UserDashboard(UTILS.Session.CurrentUser));
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
    }
}
