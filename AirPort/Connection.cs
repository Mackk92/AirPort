using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirPort
{
    class Connection
    {

        
        static internal string login="administrator";
        static internal string net= ".";
        static internal string pass="administrator1";
        static internal string datab="AirPort";
        static internal int k;
        static internal string Query;

        static internal string GetConnectionString()
        {

            return "Data Source=MONIA;Initial Catalog=AirPort;Integrated Security=False;User ID=administrator;Password=administrator1;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        }
        private void SetConnectionString(string log, string haslo, string network, string baza)
        {
            login = log;
            pass = haslo;
            net = network;
            datab = baza;

        }

        static internal int checkUser(string u, string p)
        {
            string connectionString = GetConnectionString();
            SqlConnection con = new SqlConnection("Data Source=MONIA;Initial Catalog=AirPort;Integrated Security=False;User ID=administrator;Password=administrator1;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            con.Open();
            SqlCommand cmd = new SqlCommand("logincheck", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@u", SqlDbType.VarChar, 255).Value = u;
            cmd.Parameters.Add("@p", SqlDbType.VarChar, 255).Value = p;
            SqlParameter p1 = new SqlParameter("ret", SqlDbType.Int);
            p1.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p1);
            cmd.ExecuteNonQuery();
            k = Convert.ToInt32(cmd.Parameters["ret"].Value);
            cmd.Dispose();
            return k; // if -1 null if 1 ok if -2 wrong
        }
        internal static bool IsServerConnected(string connectionString)
        {
            using (SqlConnection connection = new SqlConnection("Data Source=MONIA;Initial Catalog=AirPort;Integrated Security=False;User ID=administrator;Password=administrator1;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
            {
                try
                {
                    connection.Open();
                    return true;
                }
                catch (SqlException)
                {
                    return false;
                }
            }
        }

       
      
        




    }
}