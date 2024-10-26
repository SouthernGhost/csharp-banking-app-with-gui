using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoP_Project
{
    static class DataChk
    {
        //-------Parameters Definitions-------//
        /*
         * a is email when creating account.
         * b is password
         * re_b is retyped password which is same as b
         * c is first name
         * d is last name
         * e is security key
         */

        private static bool alphasym(string str) 
        {
            return Regex.IsMatch(str, @"^[a-zA-Z]*$");
        }
        private static bool namechk(string str) 
        {
            return Regex.IsMatch(str, @"^[0-9]*$");
        }
        private static bool validemail(string str) 
        {
            try
            {
                var mail = new System.Net.Mail.MailAddress(str);
                return mail.Address == str;
            }
            catch(Exception e) 
            {
                Msgs.erremailnonvalid();
                return Msgs.errclear = false;
            }
        }

        //-------Login data check-------//
        public static bool chklogin(string a, string b) 
        {
            if (a == "") { Msgs.erremailnull(); return Msgs.errclear = false; }
            if (validemail(a) == false) { MessageBox.Show("Please enter a valid email."); return Msgs.errclear = false; }
            if (b == "") { Msgs.errpassnull(); return Msgs.errclear = false; }
            else { return Msgs.errclear = true; }
        }

        //-----Account information check-----//
        public static bool chkinfo_m(string a, string b, string re_b, string c, string d, string e)
        {
            if (c == "") { Msgs.errfnamenull(); return Msgs.errclear = false; }
            if (namechk(c)==true) { Msgs.errfnameinvalid();return Msgs.errclear = false; }
            if (d == "") { Msgs.errlnamenull(); return Msgs.errclear = false; }
            if (namechk(d) == true) { Msgs.errlnameinvalid(); return Msgs.errclear = false; }
            if (a == "") {Msgs.erremailnull(); return Msgs.errclear = false; }
            if (validemail(a) == false) { return Msgs.errclear=false; }
            if (b == "") {Msgs.errpassnull(); return Msgs.errclear = false; }
            if (b.Length < 6) { Msgs.errpassshort(); return Msgs.errclear = false; }
            if (re_b != b) { Msgs.errpassnotmatch(); return Msgs.errclear = false; }
            if (e == "") { Msgs.errseckeynull(); return Msgs.errclear = false; }
            if (e.Length < 8) { Msgs.errseckeyshort(); return Msgs.errclear = false; }
            else { return Msgs.errclear = true; }
        }
        public static bool chkinfo_m(string a, string b, string c, string d, string e)
        {
            if (a == "") { Msgs.errfnamenull(); return Msgs.errclear = false; }
            if (namechk(a) == true) { Msgs.errfnameinvalid(); return Msgs.errclear = false; }
            if (b == "") { Msgs.errlnamenull(); return Msgs.errclear = false; }
            if (namechk(b) == true) { Msgs.errlnameinvalid(); return Msgs.errclear = false; }
            if (d == "") { Msgs.erremailnull(); return Msgs.errclear = false; }
            if (c == "") { Msgs.errpassnull(); return Msgs.errclear = false; }
            if (c.Length < 6) { Msgs.errpassshort(); return Msgs.errclear = false; }
            if (e == "") { Msgs.errseckeynull(); return Msgs.errclear = false; }
            if (e.Length < 8) { Msgs.errseckeyshort(); return Msgs.errclear = false; }
            else { return Msgs.errclear = true; }
        }
        public static bool chkinfo_m(string a,string b,string c) 
        {
            if (a == "") { Msgs.erremailnull(); return Msgs.errclear = false; }
            if (b == "") { Msgs.errseckeynull(); return Msgs.errclear = false; }
            if (c == "") { Msgs.errpassnull(); return Msgs.errclear = false; }
            if (c.Length < 6) { Msgs.errpassshort(); return Msgs.errclear = false; }
            else { return Msgs.errclear = true; }
        }

        //-------Amount check-----//
        public static bool chkdepo_m(string a) 
        {
            if (a == "") { Msgs.errdepositnull(); return Msgs.errclear = false; }
            try {
                if (Convert.ToInt32(a) < 0)
                { 
                    Msgs.errdepositneg();
                    return Msgs.errclear = false;
                }
            }
            catch (Exception e) 
            {
                Msgs.errdepositneg();
                return Msgs.errclear = false;
            }
            if (alphasym(a) == true) 
            {
                MessageBox.Show("Please enter a valid amount.");return Msgs.errclear = false;
            }
            
            else { return Msgs.errclear = true; } 
        }
        //----Withdrawal data check-----// 
        public static bool chkwithdraw_m(string a,string b) 
        {
            if (a == "") { Msgs.errwithdrawnull(); return Msgs.errclear = false; }
            try
            {
                if (Convert.ToInt32(a) < 0)
                {
                    Msgs.errwithdrawneg();
                    return Msgs.errclear = false;
                }
            }
            catch (Exception e)
            {
                Msgs.errwithdrawneg();
                return Msgs.errclear = false;
            }
            if (alphasym(a) == true)
            {
                MessageBox.Show("Please enter a valid amount."); return Msgs.errclear = false;
            }
            if (b == "") { Msgs.errseckeynull(); return Msgs.errclear = false; }

            else { return Msgs.errclear = true; }

        }
        public static bool chktransfer_m(string a,string b, string c) 
        {
            if (a == "") { Msgs.errtransemailnull(); return Msgs.errclear = false; }
            if (b == "") { Msgs.errtransnull(); return Msgs.errclear = false; }
            if (alphasym(b) == true) { MessageBox.Show("Please enter a valid amount."); return Msgs.errclear = false; }
            try
            {
                if (Convert.ToInt32(b) < 0)
                {
                    Msgs.errwithdrawneg();
                    return Msgs.errclear = false;
                }
            }
            catch (Exception e)
            {
                Msgs.errwithdrawneg();
                return Msgs.errclear = false;
            }
            if (c == "") { Msgs.errseckeynull(); return Msgs.errclear = false; }
            else return Msgs.errclear = true;
        }
    }
}
