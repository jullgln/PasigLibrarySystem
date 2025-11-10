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
    public partial class ReserveBookForm : Form
    {
        public ReserveBookForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            UIRounder.FormRounder(this, 30);
            UIRounder.RoundBtn(Cancelbtn, 20);
            UIRounder.RoundBtn(reservebtn, 25);
            Cancelbtn.BackColor = UIColors.Crimson;
            Cancelbtn.ForeColor = UIColors.White;
            reservebtn.BackColor = UIColors.VividAzure;
            reservebtn.ForeColor = UIColors.White;
        }
    }
}
