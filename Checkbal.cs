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
    public partial class Checkbal : Form
    {
        private static Checkbal ins;
        public static Checkbal getins() 
        {
            if (ins==null || ins.IsDisposed) 
                ins = new Checkbal();
            else ins.BringToFront(); return ins;
        }
        public Checkbal()
        {
            InitializeComponent();
        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void CheckBalance_Load(object sender, EventArgs e)
        {
            lblbal.Text = Account.tmpbal+" Credits";
        }

        private void btnok_Click(object sender, EventArgs e) => Close();
    }
}
