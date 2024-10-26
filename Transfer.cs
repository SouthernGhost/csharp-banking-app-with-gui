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
    public partial class Transfer : Form
    {
        private static Transfer ins;
        public static Transfer getins()
        {
            if (ins == null || ins.IsDisposed)
                ins = new Transfer();
            else ins.BringToFront(); return ins;
        }
        public Transfer()
        {
            InitializeComponent();
        }

        private void btncancel_Click(object sender, EventArgs e) => Close();

        

        private void btntransfer_Click(object sender, EventArgs e)
        {
            Account.email = txtboxemail.Text;
            Account.transfer = txtboxtrans.Text;
            Account.seckey = txtboxseckey.Text;
            Account.transfer_m(Account.email, Account.transfer, Account.seckey);
            if (Account.transfer_bool == true)
            {
                Msgs.succtrans();this.Close();
            }
        }

        private void Transfer_Load(object sender, EventArgs e)
        {

        }
    }
}
