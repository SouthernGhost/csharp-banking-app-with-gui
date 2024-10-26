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
    public partial class Newusers : Form
    {
        private static Newusers ins;
        public static Newusers getins()
        {
            if (ins == null || ins.IsDisposed)
                ins = new Newusers();
            else ins.BringToFront(); return ins;
        }
        public Newusers()
        {
            InitializeComponent();
        }

        private void newuserscreen_Load(object sender, EventArgs e)
        {

        }

        private void btncancelsignup_Click(object sender, EventArgs e)
        {
            Loginscreen btnaddcancel = Loginscreen.getins();
            btnaddcancel.Show();
            Account.addacc_bool = false;
            this.Close();
        }

        private void btnsignup_Click(object sender, EventArgs e)
        {       
            Account.email = txtboxemail.Text;
            Account.pass = txtboxpassword.Text;
            Account.repass=txtboxrepassword.Text ;
            Account.fname = txtboxfirstname.Text;
            Account.lname = txtboxlastname.Text;
            Account.seckey = txtboxsecuritykey.Text;
            Account.bal = 1000;
            Account.addacc_m(Account.email,Account.pass,Account.repass,Account.fname,Account.lname,Account.seckey,Account.bal);
            if (Account.addacc_bool == true) 
            {
                Loginscreen addaccsucc = Loginscreen.getins();
                addaccsucc.Show();
                this.Close();
            }
        }
        private void Newusers_FormClosing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Loginscreen btnclose = new Loginscreen();
            btnclose.Show();
            this.Close();
        }
    }
}
