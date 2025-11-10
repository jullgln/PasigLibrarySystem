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
    }
}
