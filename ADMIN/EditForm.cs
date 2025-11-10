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
    public partial class EditForm : Form
    {
        public EditForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            UIRounder.FormRounder(this, 30);
            //for button rounder
            UIRounder.RoundBtn(savebtn, 20);
            UIRounder.RoundBtn(Cancelbtn, 20);
            //for colors
            savebtn.BackColor = UIColors.VividAzure;
            savebtn.ForeColor = UIColors.White;
            Cancelbtn.BackColor = UIColors.Crimson;
            Cancelbtn.ForeColor = UIColors.White;
        }

        private void Cancelbtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            //add validation here
            Close();
        }
    }
}
