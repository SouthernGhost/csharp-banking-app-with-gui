using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoP_Project
{
    public partial class Deposit : Form
    {
        private static Deposit ins;
        public static Deposit getins()
        {
            if (ins == null || ins.IsDisposed)
                ins = new Deposit();
            else ins.BringToFront(); return ins;
        }
        public Deposit()
        {
            InitializeComponent();
        }

        private void btncancel_Click(object sender, EventArgs e) => Close();

        private void Deposit_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btndeposit_Click(object sender, EventArgs e)
        {
            Account.deposit = txtboxdeposit.Text;
            Account.deposit_m(Account.deposit);
            if (Account.deposit_bool == true)
            {
                Msgs.succdeposit();
                this.Close();
            }

        }
    }
}

