// This class allows access to database by establishing connection to it

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FoP_Project
{
    public class DB_Access
    {
        public static string constring = Properties.Settings.Default.AccountsConnectionString;
        public static bool query;
        public static bool v;


        //--------------------Methods-------------------//


        //------Login Method-------//
        public static bool loginfetch(string a, string b)
        {
            SqlCommand cmd;
            SqlDataReader reader;
            string existquery = "select email,pass from AccTable where exists (select email,pass from AccTable where email='" + a + "' and  pass='" + b + "')";
            string readquery = "select * from AccTable where email='" + a + "' AND pass='" + b + "'";
            SqlConnection conn = new SqlConnection(constring);
            conn.Open();
            //Record check sequence
            {
                cmd = new SqlCommand(existquery, conn);
                reader = cmd.ExecuteReader();
                v = reader.Read();
                if (v == false) { Msgs.errnorecord(); return Account.login_bool = false; }
                else { DB_Access.query = true; }
                reader.Close();
            }
            //Read sequence
            if (DB_Access.query == true)
            {
                DataTable tmpdata = new DataTable();
                cmd = new SqlCommand(readquery, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(tmpdata);
                if (tmpdata.Rows.Count == 1)
                {
                    Account.tmpemail = tmpdata.Rows[0]["email"].ToString();
                    Account.pass = tmpdata.Rows[0]["pass"].ToString();
                    Account.tmpfname = tmpdata.Rows[0]["fname"].ToString();
                    Account.tmplname = tmpdata.Rows[0]["lname"].ToString();
                    Account.tmpseckey = tmpdata.Rows[0]["seckey"].ToString();
                    Account.tmpid = tmpdata.Rows[0]["ID"].ToString();
                }
                else { MessageBox.Show("Error occurred while fetching data."); }
            }
            cmd.Dispose();
            conn.Close();
            if (v == true) { Account.login_bool = true; }
            return Account.login_bool;
        }

        //------New account method-------//
        public static bool addacc_db(string a, string b, string re_b, string c, string d, string e, long f)
        {
            SqlCommand cmd;
            SqlDataReader reader;
            string existquery = "select email from AccTable where exists (select email from AccTable where email='" + a + "')";
            string insertdata = "insert into AccTable (email,pass,fname,lname,seckey,bal) values('" + a + "','" + b + "','" + c + "','" + d + "','" + e + "','" + f + "')";
            SqlConnection conn = new SqlConnection(constring);
            conn.Open();
            //Record check sequence
            {
                cmd = new SqlCommand(existquery, conn);
                reader = cmd.ExecuteReader();
                v = reader.Read();
                if (v == true)
                {
                    Msgs.erremailexist();
                    reader.Close();
                    cmd.Dispose();
                    conn.Close();
                    return Account.login_bool = false;
                }
                else { DB_Access.query = true; }
                reader.Close();
            }
            if (DB_Access.query == true)
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable idtable= new DataTable();
                cmd = new SqlCommand(insertdata, conn);
                adapter.InsertCommand = new SqlCommand(insertdata, conn);
                adapter.InsertCommand.ExecuteNonQuery();
                cmd.Dispose();
                adapter.Dispose();
                conn.Close();
                conn = new SqlConnection(constring);
                conn.Open();
                SqlCommand cmd2;
                SqlDataAdapter adapter2;
                string newquery = "select ID from AccTable where email='" + a + "'";
                cmd2 = new SqlCommand(newquery,conn);
                adapter2 = new SqlDataAdapter(cmd2);
                adapter2.Fill(idtable);
                string x = idtable.Rows[0]["ID"].ToString();
                accstat.create_m(a, c, d, x);
                adapter2.Dispose();
                conn.Close();
                Msgs.succaddacc();
            }
            return DB_Access.query = true;
        } //End of addacc_db method

        //-------Balance inquiry method------//
        public static uint fetchbal()
        {
            SqlConnection conn = new SqlConnection(constring);
            conn.Open();
            SqlCommand cmd;
            string balquery = "Select ID,bal from AccTable where ID='" + Account.tmpid + "'";
            DataTable tmpbal = new DataTable();
            cmd = new SqlCommand(balquery, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(tmpbal);
            if (tmpbal.Rows.Count == 1)
            {
                Account.tmpbal = Convert.ToUInt32(tmpbal.Rows[0]["bal"]);
            }
            cmd.Dispose();
            conn.Close();
            return Account.tmpbal;
        }

        //-----Deposit method-----//
        public static bool deposit_db(string a)
        {
            SqlConnection conn = new SqlConnection(constring);
            conn.Open();
            SqlCommand cmd;
            //Balance retrieval
            string balquery = "Select ID,bal from AccTable where ID='" + Account.tmpid + "'";
            DataTable tmpbal = new DataTable();
            cmd = new SqlCommand(balquery, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(tmpbal);
            if (tmpbal.Rows.Count == 1)
            {
                Account.tmpbal = uint.Parse(tmpbal.Rows[0]["bal"].ToString());
            }
            cmd.Dispose();
            Account.tmpbal = Account.tmpbal + uint.Parse(a);
            string depositquery = "Update AccTable set bal = '" + Convert.ToString(Account.tmpbal) + "' where ID ='" + Account.tmpid + "'";
            cmd = new SqlCommand(depositquery, conn);
            adapter.UpdateCommand = new SqlCommand(depositquery, conn);
            adapter.UpdateCommand.ExecuteNonQuery();
            cmd.Dispose();
            conn.Close();
            accstat.deposit_stat(a, Convert.ToString(Account.tmpbal),Account.tmpid);
            return Account.deposit_bool = true;
        }

        //------Withdraw method-----//
        public static bool withdraw_db(string a, string b)
        {
            SqlConnection conn = new SqlConnection(constring);
            conn.Open();
            SqlCommand cmd;
            //Balance check
            string balquery = "Select ID,bal from AccTable where ID='" + Account.tmpid + "'";
            DataTable tmpbal = new DataTable();
            cmd = new SqlCommand(balquery, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(tmpbal);
            if (tmpbal.Rows.Count == 1)
            {
                Account.tmpbal = uint.Parse(tmpbal.Rows[0]["bal"].ToString());
            }
            cmd.Dispose();
            if ((uint.Parse(a) > Account.tmpbal))
            {
                MessageBox.Show("The amount you are trying to withdraw is more\nthan your current balance. Please try again.");
                return Account.withdraw_bool = false;
            }
            if (Account.tmpbal == 0)
            {
                MessageBox.Show("Your current balance is zero.");
                return Account.withdraw_bool = false;
            }
            if (b != Account.tmpseckey)
            {
                MessageBox.Show("Wrong security key.");
                return Account.withdraw_bool = false;
            }
            else
            {
                Account.tmpbal = Account.tmpbal - uint.Parse(a);
                string drawquery = "Update AccTable set bal = '" + Convert.ToString(Account.tmpbal) + "' where ID ='" + Account.tmpid + "'";
                cmd = new SqlCommand(drawquery, conn);
                adapter.UpdateCommand = new SqlCommand(drawquery, conn);
                adapter.UpdateCommand.ExecuteNonQuery();
                cmd.Dispose();
                conn.Close();
                accstat.withdraw_stat(a,Convert.ToString(Account.tmpbal),Account.tmpid);
                return Account.withdraw_bool = true;
            }
        }

        //------Transfer method-----//
        public static bool transfer_db(string a, string b, string c)
        {
            SqlCommand cmd;
            SqlDataReader reader;
            string existquery = "select email from AccTable where exists (select email from AccTable where email='" + a + "')";
            SqlConnection conn = new SqlConnection(constring);
            conn.Open();
            //Record check sequence
            {
                cmd = new SqlCommand(existquery, conn);
                reader = cmd.ExecuteReader();
                v = reader.Read();
                if (v == false)
                {
                    MessageBox.Show("Such an account with given email does not exist");
                    return Account.transfer_bool = false;
                }
                else { DB_Access.query = true; }
                reader.Close();
                cmd.Dispose();
            }
            if (DB_Access.query == true)
            {
                //Balance check
                string balquery = "Select ID,bal from AccTable where ID='" + Account.tmpid + "'";
                DataTable tmpbal = new DataTable();
                cmd = new SqlCommand(balquery, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(tmpbal);
                if (tmpbal.Rows.Count == 1)
                {
                    Account.tmpbal = uint.Parse(tmpbal.Rows[0]["bal"].ToString());
                }
            }
            cmd.Dispose();
            if ((uint.Parse(b) > Account.tmpbal))
            {
                MessageBox.Show("The amount you are trying to transfer is more\nthan your current balance.");
                return Account.transfer_bool = false;
            }
            if (Account.tmpbal == 0)
            {
                MessageBox.Show("Your current balance is zero.");
                return Account.transfer_bool = false;
            }
            if (c != Account.tmpseckey)
            {
                MessageBox.Show("Wrong security key.");
                return Account.transfer_bool = false;
            }
            //Recipient's balance update
            else
            {
                SqlDataAdapter adapter_t = new SqlDataAdapter();
                string balquery_t = "Select email,bal,ID from AccTable where email='" + a + "'";
                DataTable tmpbal_t = new DataTable();
                cmd = new SqlCommand(balquery_t, conn);
                adapter_t = new SqlDataAdapter(cmd);
                adapter_t.Fill(tmpbal_t);
                {
                    Account.reciid = tmpbal_t.Rows[0]["ID"].ToString();
                    Account.recibal = uint.Parse(tmpbal_t.Rows[0]["bal"].ToString());
                }
                cmd.Dispose();
                Account.recibal = Account.recibal + uint.Parse(b);
                string depositquery = "Update AccTable set bal = '" + Convert.ToString(Account.recibal) + "' where email ='" + a + "'";
                cmd = new SqlCommand(depositquery, conn);
                adapter_t.UpdateCommand = new SqlCommand(depositquery, conn);
                adapter_t.UpdateCommand.ExecuteNonQuery();
                cmd.Dispose();
                //Sender's balance update
                Account.tmpbal = Account.tmpbal - uint.Parse(b);
                SqlDataAdapter adapter_s = new SqlDataAdapter();
                string drawquery = "Update AccTable set bal = '" + Convert.ToString(Account.tmpbal) + "' where ID ='" + Account.tmpid + "'";
                cmd = new SqlCommand(drawquery, conn);
                adapter_s.UpdateCommand = new SqlCommand(drawquery, conn);
                adapter_s.UpdateCommand.ExecuteNonQuery();
                cmd.Dispose();
                conn.Close();
                Account.transfer_bool = true;
            }
            return Account.transfer_bool = true;
        }
        
        //-------Password reset------//
        public static bool passreset_db(string a,string b,string c)
        {
            SqlCommand cmd;
            SqlDataReader reader;
            string existquery = "select email,seckey from AccTable where exists (select email from AccTable where email='" + a +"' and seckey='"+b+"')";
            SqlConnection conn = new SqlConnection(constring);
            conn.Open();
            //Record check sequence
            cmd = new SqlCommand(existquery, conn);
            reader = cmd.ExecuteReader();
            v = reader.Read();
            if (v == false)
            {
                MessageBox.Show("Email or Security Key is wrong.");
                reader.Close();
                cmd.Dispose();
                conn.Close();
                return Account.passreset_bool = false;
            }
            else { DB_Access.query = true; }
            reader.Close();
            cmd.Dispose();
            if (DB_Access.query == true)
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                string passquery = "update AccTable set pass='" + c + "' where email='" + a + "'";
                cmd = new SqlCommand(passquery, conn);
                adapter.UpdateCommand = new SqlCommand(passquery, conn);
                adapter.UpdateCommand.ExecuteNonQuery();
                cmd.Dispose();
                conn.Close();
                Account.passreset_bool = true;
            }
            return Account.passreset_bool;
        }
    }
}
