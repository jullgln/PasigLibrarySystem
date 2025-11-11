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
    public partial class ViewDetails : Form
    {
        public ViewDetails()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            UIRounder.FormRounder(this, 30);
            UIRounder.RoundBtn(backtosearch, 20);
            backtosearch.BackColor = UIColors.VividAzure;
            backtosearch.ForeColor = UIColors.White;

            //details
            idtxt.Text = DATABASES.book_data.currentbookid;
            titletxt.Text = DATABASES.book_data.currentbookname;
            authortxt.Text = DATABASES.book_data.currentbookauthor;
            genretxt.Text = DATABASES.book_data.currentgenre;
            pubdatetxt.Text = DATABASES.book_data.currentpublishdate;
            statustxt.Text = DATABASES.book_data.currentstatus;

        }


        private void backtosearch_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
