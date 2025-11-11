using PasigLibrarySystem.DATABASES;
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
        private string dateBorrowed;
        private decimal fineAmount = 250.00m;
        public LostForm(string dateBorrowed)
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

            // Store the date borrowed
            this.dateBorrowed = dateBorrowed;

            titletxt.Text = book_data.currentbookname;
            idtxt.Text = book_data.currentbookid;
            displayname.Text = user_data.real_name;
            borrowdatetxt.Text = dateBorrowed;

            lostdatetxt.Text = DateTime.Now.ToString("yyyy-MM-dd");

            finetxt.Text = fineAmount.ToString("0.00");
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

        private void amounttxt_TextChanged(object sender, EventArgs e)
        {
            double amountPaid=amounttxt.Text.Length;
            
            double amount=amountPaid- (double)fineAmount;
            changetxt.Text = amount.ToString("0.00");
        }
    }
}
