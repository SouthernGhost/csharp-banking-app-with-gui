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
    public partial class Loginscreen : Form
    {
        private static Loginscreen ins;
        public static Loginscreen getins()
        {
            if (ins == null||ins.IsDisposed)
                ins = new Loginscreen();
            else ins.BringToFront();
            Account.tmpemail = ""; Account.tmpfname = ""; Account.tmplname = ""; Account.tmpseckey = "";

            return ins;
        }
        public Loginscreen()
        {
            InitializeComponent();
        }
        private void btnadduser_Click(object sender, EventArgs e)
        {
            Newusers btnadduser = Newusers.getins();
            btnadduser.Show();
            this.Close();
            if (Account.addacc_bool == true)
            {
                btnadduser.Close();
                this.Show();
            }
        }

        private void btnlogin_Click_1(object sender, EventArgs e)
        {
            Account.email = txtboxemail.Text;
            Account.pass = txtboxpassword.Text;
            Account.login_m(Account.email, Account.pass);
            if (Account.login_bool == true)
            {
                Home btnlogin = new Home();
                btnlogin.Show();
                this.Close();
            }
            
        }

        public void LoginScreen_Load(object sender, EventArgs e)
        {
            Account.logout_bool = true;
            if (Account.logout_bool == true)
            {
                txtboxemail.Text = ""; txtboxpassword.Text = "";
                Account.tmpemail = ""; Account.tmpfname = ""; Account.tmplname = ""; Account.tmpseckey = "";
            }

        }

        private void btnpassreset_Click(object sender, EventArgs e)
        {
            Passreset btnpassreset = Passreset.getins();
            btnpassreset.Show();
            this.Close();
        }

        public void txtboxaccountid_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtboxaccountid_MouseHover(object sender, EventArgs e)
        {
            tipaccid.SetToolTip(txtboxemail, "Enter your email.");
        }

        private void txtboxpassword_MouseHover(object sender, EventArgs e)
        {
            tippass.SetToolTip(txtboxpassword, "Enter your account's password.");
        }

        private void btnpassreset_MouseHover(object sender, EventArgs e)
        {
            tippassreset.SetToolTip(btnpassreset, "Click to reset password.");
        }

        private void btnadduser_MouseHover(object sender, EventArgs e)
        {
            tipnewacc.SetToolTip(btnadduser, "Click to create account.");
        }

        public void txtboxpassword_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void accountsBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void tipaccid_Popup(object sender, PopupEventArgs e)
        {

        }
        private void Loginscreen_FormClosing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Application.Exit();
        }
    }
}

