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
    public partial class LostForm : Form
    {
        public LostForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            UIRounder.FormRounder(this, 30);
            UIRounder.RoundBtn(Cancelbtn, 20);
            UIRounder.RoundBtn(settleaccbtn, 20);
            Cancelbtn.BackColor = UIColors.Crimson;
            Cancelbtn.ForeColor = UIColors.White;
            settleaccbtn.BackColor = UIColors.DarkBlue;
            settleaccbtn.ForeColor = UIColors.White;
        }

        private void Cancelbtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void settleaccbtn_Click(object sender, EventArgs e)
        {
            //validation
            Close();
        }
    }
}
