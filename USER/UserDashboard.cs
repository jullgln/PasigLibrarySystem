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
    public partial class UserDashboard : Form
    {
        public UserDashboard()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            UIRounder.FormRounder(this, 30);
            highlightpanel.BackColor = UIColors.VividAzure;
        }
    }
}
