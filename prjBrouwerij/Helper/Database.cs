using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;

namespace prjBrouwerij.Helper
{
    public class Database
    {
        //methode schrijven om de verbinding met de databank te maken
        public static MySqlConnection MaakVerbinding()
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();

            builder.Server = "localhost";
            builder.Database = "bierdb";
            builder.UserID = "root";
            builder.Password = "usbw";
            builder.ConnectionTimeout = 60;
            builder.Port = 3307;
            builder.AllowZeroDateTime = true;

            MySqlConnection conn = new MySqlConnection(builder.ToString());
            conn.Open();

            return conn;
        }

        //dit is niet per se nodig
        public static void CloseConnection(MySqlConnection conn)
        {
            if(conn != null)
            {
                conn.Close();
                conn = null;
            }
        }
    }
}
