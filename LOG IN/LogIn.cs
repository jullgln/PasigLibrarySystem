using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasigLibrarySystem
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            UIRounder.FormRounder(this, 30);
            H1.ForeColor = UIColors.DarkBlue;
            lbl1.ForeColor = UIColors.DarkBlue;
            lbl2.ForeColor = UIColors.DarkBlue;
            lbl3.ForeColor = UIColors.DarkBlue;
            link1.ForeColor = UIColors.DarkBlue;
            UIRounder.RoundBtn(LogInbtn, 20);
            LogInbtn.BackColor = UIColors.VividAzure;
            LogInbtn.ForeColor = UIColors.White;
        }

        private void link2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUp signUpForm = new SignUp();
            signUpForm.Show();
            this.Hide();
        }
    }
}
