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
    
    public partial class Accountstat : Form
    {
        private static Accountstat ins;
        public static Accountstat getins()
    {
        if (ins == null || ins.IsDisposed)
            ins = new Accountstat();
        else ins.BringToFront(); return ins;
    }
        public Accountstat()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Accountstat_Load(object sender, EventArgs e)
        {

        }

        private void btnviewstat_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Users\Public\Documents\Bank Statements\BnkStat."+Account.tmpid+".txt");
        }

        private void btnemail_Click(object sender, EventArgs e)
        {
            //string name = Account.tmpfname + " " + Account.tmplname;
            //accstat.email_stat(Account.tmpemail,name,Account.tmpid);
        }
    }
}
