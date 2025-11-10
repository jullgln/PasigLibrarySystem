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
    public partial class UserBorrowForm : Form
    {
        public UserBorrowForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            UIRounder.FormRounder(this, 30);
            UIRounder.RoundBtn(borrowbtn, 25);
            UIRounder.RoundBtn(Cancelbtn, 20);
            borrowbtn.BackColor = UIColors.VividAzure;
            borrowbtn.ForeColor = UIColors.White;
            Cancelbtn.BackColor = UIColors.Crimson;
            Cancelbtn.ForeColor = UIColors.White;
        }
    }
}
