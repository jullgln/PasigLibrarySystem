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
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.None;
            UIRounder.FormRounder(this, 30);
            H1.ForeColor = UIColors.DarkBlue;
            lbl1.ForeColor = UIColors.DarkBlue;
            lbl2.ForeColor = UIColors.DarkBlue;
            lbl3.ForeColor = UIColors.DarkBlue;
            lbl4.ForeColor = UIColors.DarkBlue;
            UIRounder.RoundBtn(Registerbtn, 20);
            Registerbtn.BackColor = UIColors.VividAzure;
            Registerbtn.ForeColor = UIColors.White;
        }

        private void Registerbtn_Click(object sender, EventArgs e)
        {
            LogIn LogInForm = new LogIn();
            LogInForm.Show();
            this.Hide();
        }
    }
}
