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
    public partial class ReturnForm : Form
    {
        public ReturnForm(string dateBorrowed, string dateReturn)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            UIRounder.FormRounder(this, 30);
            UIRounder.RoundBtn(returnbtn, 25);
            UIRounder.RoundBtn(Cancelbtn, 20);
            returnbtn.BackColor = UIColors.VividAzure;
            returnbtn.ForeColor = UIColors.White;
            Cancelbtn.BackColor = UIColors.Crimson;
            Cancelbtn.ForeColor = UIColors.White;
            settleaccbtn.BackColor = UIColors.DarkBlue;
            settleaccbtn.ForeColor = UIColors.White;
        }

        private void settleaccbtn_Click(object sender, EventArgs e)
        {
            //validation
            //change display if there is change
        }

        private void Cancelbtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void returnbtn_Click(object sender, EventArgs e)
        {
            //validation
            Close();
        }
    }
}
