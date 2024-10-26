using System;
using System.IO;
using System.Net.Mail;
using System.Text;

namespace FoP_Project
{
    public static class accstat
    {                    
        static string dir = @"C:\Users\Public\Documents\Bank Statements\";
        public static bool emailsucc;
        public static void create_m(string a, string b, string c, string d)
        {
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }
            else
            {
                string filename = "BnkStat." + d + ".txt";
                string s = "Account Statement\n" + b + " " + c + "\nEmail: " + a + "\nAccount ID: " + d + "\n";
                byte[] info = new UTF8Encoding(true).GetBytes(s);
                FileStream create = File.Create(dir + filename);
                create.Write(info, 0, info.Length);
                create.Flush(); create.Close();
            }
        }
        public static void deposit_stat(string a, string b, string c)
        {
            string filename = "BnkStat." + c + ".txt";
            string s = "\n" + a + " Credits deposited on " + Convert.ToString(DateTime.Now) + " Balance: " + b;
            {
                byte[] info = new UTF8Encoding(true).GetBytes(s);
                FileStream create = File.Open(dir + filename, FileMode.Append,FileAccess.Write);
                create.Write(info, 0, info.Length);
                create.Flush(); create.Close();
            }
        }
        public static void withdraw_stat(string a, string b, string c)
        {
            string filename = "BnkStat." + c + ".txt";
            string s = "\n" + a + " Credits withdrawn on " + Convert.ToString(DateTime.Now) + " Balance: " + b;
            {
                byte[] info = new UTF8Encoding(true).GetBytes(s);
                FileStream create = File.Open(dir + filename, FileMode.Append,FileAccess.Write);
                create.Write(info, 0, info.Length);
                create.Flush(); create.Close();
            }
        }
        //public static bool email_stat(string a,string b,string c)
        //{
        //    string filename = "BnkStat." + c + ".txt";
        //    MailAddress From = new MailAddress("mabdullah.mts41ceme@mts.ceme.edu.pk");
        //    MailAddress To = new MailAddress(a);
        //    MailMessage email = new MailMessage(From, To);
        //    email.Subject = "Account Statement";
        //    email.Body = "Hi " + b+"!\n\tAttatched with this E-mail is the statement of your account that you requested on"+Convert.ToString(DateTime.Now);
        //    email.Attachments.Add(new Attachment(dir+filename));
        //    SmtpClient smtp = new SmtpClient();
        //    smtp.Port = 587;
        //    smtp.Host = "smtp.gmail.com"; 
        //    smtp.EnableSsl = true;
        //    smtp.UseDefaultCredentials = false;
        //    smtp.Credentials = new System.Net.NetworkCredential("mabdullah.mts41ceme@mts.ceme.edu.pk", "BoomBoom");
        //    smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
        //    smtp.Send(email);
        //    return emailsucc = true;
        //}

    }
}
