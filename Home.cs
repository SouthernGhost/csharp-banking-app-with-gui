using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoP_Project
{
    public partial class Home : Form
    {
        public static bool logout_bool;
        public Home()
        {
            InitializeComponent();
        }

        public void btnlogout_Click(object sender, EventArgs e)
        {
            Account.logout_bool = true;
            Account.login_bool = false;
            Loginscreen btnlogout = Loginscreen.getins();
            btnlogout.Show();
            this.Close();

        }

        private void home_Load(object sender, EventArgs e)
        {
            lblweluser.Text = "Welcome " + Account.tmpfname + " " + Account.tmplname;
        }

        private void btnchkbalance_Click(object sender, EventArgs e)
        {
            DB_Access.fetchbal();
            Checkbal btnchkbal = Checkbal.getins();
            btnchkbal.Show();
        }

        private void btndeposit_Click(object sender, EventArgs e)
        {
            Deposit btndeposit = Deposit.getins();
            btndeposit.Show();
        }

        private void btnwithdraw_Click(object sender, EventArgs e)
        {
            Withdraw btnwithdraw = Withdraw.getins();
            btnwithdraw.Show();
        }

        private void btntransfer_Click(object sender, EventArgs e)
        {
            Transfer btntransfer = Transfer.getins();
            btntransfer.Show();
        }

        private void btnsignout_MouseHover(object sender, EventArgs e)
        {
            tiplogout.SetToolTip(btnsignout, "Click to logout of your account and go back to login screen.");
        }

        private void btnaccstat_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Users\Public\Documents\Bank Statements\BnkStat." + Account.tmpid + ".txt");
            //Accountstat btnaccstat = Accountstat.getins();
            //btnaccstat.Show();
        }

    }
}



