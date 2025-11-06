using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace PasigLibrarySystem.LOG_IN
{
    public partial class ForgotPass : Form
    {
        public ForgotPass()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            UIRounder.FormRounder(this, 30);
            H1.ForeColor = UIColors.DarkBlue;
            lbl1.ForeColor = UIColors.DarkBlue;
            lbl2.ForeColor = UIColors.DarkBlue;
            lbl3.ForeColor = UIColors.DarkBlue;
            UIRounder.RoundBtn(Resetbtn, 20);
            Resetbtn.BackColor = UIColors.VividAzure;
            Resetbtn.ForeColor = UIColors.White;
        }

        private void Resetbtn_Click(object sender, EventArgs e)
        {
            LogIn LogInForm = new LogIn();
            LogInForm.Show();
            this.Hide();
        }
    }
}
