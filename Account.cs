using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using FoP_Project;
using System.IO;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace FoP_Project
{

    public class Account
    {
        //--------------Temporary Fields To Store Data When Logging In----------//

        public static string tmpemail;
        public static string tmpid;
        public static string tmpfname;
        public static string tmplname;
        public static string tmpseckey;
        public static uint tmpbal;
        public static uint recibal;
        public static string reciid;

        //--------------Boolean Fields For Sucesses------------//

        public static bool addacc_bool;
        public static bool logout_bool;
        public static bool login_bool;
        public static bool deposit_bool;
        public static bool withdraw_bool;
        public static bool transfer_bool;
        public static bool delteacc_bool;
        public static bool editacc_bool;
        public static bool passreset_bool;

        //---------------Fields------------//

        public static string pass;          //Filed for password when creating or logging into account
        public static string repass;        //Field for retyped password when creating new account 
        public static string fname;         //Field for first name
        public static string lname;         //Filed for last name
        public static string email;         //Field for email when creating or logging into account
        public static string seckey;        //Field for security key
        public static uint bal;             //Filed for account balance
        public static string deposit;       //Field for deposited amount
        public static string withdraw;      //Field for withdrawn amount
        public static string transfer;      //Field for transferred amount

        //-------------Account Methods-----------//

        //Login method
        public static void login_m(string a, string b)
        {
            DataChk.chklogin(a, b);
            if (Msgs.errclear == true)
            {
                DB_Access.loginfetch(a,b);
            }
        }

        //New Account Method
        public static bool addacc_m(string a, string b, string re_b, string c, string d, string e, long f) //New account method
        {
            
            DataChk.chkinfo_m(a,b,re_b,c,d,e);
            if (Msgs.errclear == true)
            {
                DB_Access.addacc_db(a, b,re_b, c, d, e, f);
            }
            if (DB_Access.query == true) Account.addacc_bool = true;
            return Account.addacc_bool;
        }

        //Withdrawing Method
        public static void withdraw_m(string a,string b)
        {
            DataChk.chkwithdraw_m(a, b);
            if (Msgs.errclear == true) 
            {
                DB_Access.withdraw_db(a, b);
            }
        }

        //Depositing Method
        public static void deposit_m(string a)
        {
            DataChk.chkdepo_m(a);
            if (Msgs.errclear == true)
            {
                DB_Access.deposit_db(a);
            }
        }

        //Transferring Method
        public static void transfer_m(string a, string b, string c) 
        {
            DataChk.chktransfer_m(a, b, c);
            if (Msgs.errclear == true) 
            {
                DB_Access.transfer_db(a, b, c);
            }
        }
        public static bool passreset(string a,string b,string c) 
        {
            DataChk.chkinfo_m(a, b, c);
            if (Msgs.errclear == true) 
            {
                DB_Access.passreset_db(a, b, c);
            }
            return Account.passreset_bool;
        }

    }
}
