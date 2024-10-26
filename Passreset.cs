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
    public partial class Passreset : Form
    {
        private static Passreset ins;
        public static Passreset getins()
        {
            if (ins == null || ins.IsDisposed)
                ins = new Passreset();
            else ins.BringToFront(); return ins;
        }
        public Passreset()
        {
            InitializeComponent();
        }

        private void btnpassreset_Click(object sender, EventArgs e)
        {
            Account.pass = txtboxnewpass.Text;Account.email = txtboxemail.Text;Account.seckey = txtboxseckey.Text;
            Account.passreset(Account.email,Account.seckey,Account.pass);
            if (Account.passreset_bool == true) 
            {
                MessageBox.Show("Password reset successfully.");
                Loginscreen prs = Loginscreen.getins();
                prs.Show();
                this.Close();
            }

        }

        private void btncancel_Click(object sender, EventArgs e) 
        {
            Loginscreen btncancel = Loginscreen.getins();
            btncancel.Show();
            this.Close(); 
        }

        private void Passwordreset_Load(object sender, EventArgs e)
        {

        }
    }
}
