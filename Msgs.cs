using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoP_Project
{
    public static class Msgs
    {
        //--------------Error Booleans---------------//
        public static bool errclear;
        //--------------Fail Messages---------------//
        public static void erremailnull() 
        {
            MessageBox.Show("Please enter an email.","",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }
        public static void erremailnonvalid() 
        {
            MessageBox.Show("Please enter a valid email of format * @ *.","", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static void errnorecord() 
        {
            MessageBox.Show("Either email or password is wrong or account does not exist.","", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static void erremailexist() 
        {
            MessageBox.Show("An account with this email already exists.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static void errpassnull()
        {
            MessageBox.Show("Please enter a password.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static void errpassshort() 
        {
            MessageBox.Show("Password is too short.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static void errpassnotmatch() 
        {
            MessageBox.Show("Password does not match.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static void errfnamenull() 
        {
            MessageBox.Show("Please enter a first name.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static void errfnameinvalid() 
        {
            MessageBox.Show("Please enter a valid first name.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static void errlnamenull()
        {
            MessageBox.Show("Please enter a last name.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static void errlnameinvalid()
        {
            MessageBox.Show("Please enter a valid last name.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static void errseckeynull() 
        {
            MessageBox.Show("Please enter security key.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static void errseckeyshort() 
        {
            MessageBox.Show("Security key is too short.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static void errdepositnull() 
        {
            MessageBox.Show("Please enter an amount.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static void errdepositneg() 
        {
            MessageBox.Show("Please enter a valid positive amount.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static void errwithdrawnull() 
        {
            MessageBox.Show("Please enter an amount to withdraw.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static void errwithdrawneg() 
        {
            MessageBox.Show("Please enter a valid positive amount.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static void errtransnull() 
        {
            MessageBox.Show("Please enter an amount.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static void errtransemailnull() 
        {
            MessageBox.Show("Please enter recipient's email.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //----------------Sucess----------------------//
        public static void succaddacc() 
        {
            MessageBox.Show("Account created successfully.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static void succdeposit()
        {
            MessageBox.Show("Amount deposited succesfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static void succwithdraw()
        {
            MessageBox.Show("Amount withdrawn successfully.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static void succtrans()
        {
            MessageBox.Show("Amount transferred successfully.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
