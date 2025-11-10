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
    public partial class BorrowForm : Form
    {
        public BorrowForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            //for button rounder
            UIRounder.FormRounder(this, 30);
            UIRounder.RoundBtn(borrowbtn, 25);
            UIRounder.RoundBtn(Cancelbtn, 20);
            //for colors
            borrowbtn.BackColor = UIColors.VividAzure;
            borrowbtn.ForeColor = UIColors.White;
            Cancelbtn.BackColor = UIColors.Crimson;
            Cancelbtn.ForeColor = UIColors.White;
            //others

        }

        private void Cancelbtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void borrowbtn_Click(object sender, EventArgs e)
        {
            //validation can be added here
            MessageBox.Show("Book Borrowed Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);//placeholder
            Close();
        }
    }
}
