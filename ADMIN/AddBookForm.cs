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
    public partial class AddBookForm : Form
    {
        public AddBookForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            UIRounder.FormRounder(this, 30);
            //for button rounder
            UIRounder.RoundBtn(addbookbtn, 20);
            //for colors
            addbookbtn.BackColor = UIColors.VividAzure;
            addbookbtn.ForeColor = UIColors.White;
        }

        private void Cancelbtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void addbookbtn_Click(object sender, EventArgs e)
        {
            //add validation here
            Close();
        }
    }
}
