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
    public partial class Withdraw : Form
    {
        private static Withdraw ins;
        public static Withdraw getins()
        {
            if (ins == null || ins.IsDisposed)
                ins = new Withdraw();
            else ins.BringToFront(); return ins;
        }
        public Withdraw()
        {
            InitializeComponent();
        }

        private void btncancel_Click(object sender, EventArgs e) => Close();



        private void Withdraw_Load(object sender, EventArgs e)
        {

        }

        private void btnwithdraw_Click(object sender, EventArgs e)
        {
            Account.withdraw = txtboxwithdraw.Text;
            Account.seckey = txtboxseckey.Text;
            Account.withdraw_m(Account.withdraw, Account.seckey);
            if (Account.withdraw_bool == true)
            {
                Msgs.succwithdraw();
                this.Close();
            }
        }

        private void txtboxwithdraw_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
