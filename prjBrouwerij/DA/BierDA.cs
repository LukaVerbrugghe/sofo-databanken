using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;
using prjBrouwerij.Helper;
using prjBrouwerij.Model;

namespace prjBrouwerij.DA
{
    public class BierDA
    {
        //list nodig = object dat je gaat vullen met andere objecten uit je model (meestal onzichtbaar)
        //brouwerij obhalen, tekst (brouwerijnamen zijn dus gewoon tekst)
        public static List<string> BrouwerijenOphalen()
        {
            //alle brouwerijen in de listbox steken
            List<string> brouwerijen = new List<string>();
            //in die list steken we alle unieke brouwerijen
            string sql = "SELECT DISTINCT brouwerij FROM bier ORDER BY brouwerij ASC";

            //eerst verbinding maken met de databank
            MySqlConnection conn = Database.MaakVerbinding();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.CommandText = sql;

            //commando is gemaakt maar moet nog uitgevoerd worden
            //execute reader --> meerdere waarden
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                brouwerijen.Add(reader["brouwerij"].ToString());
            }

            reader.Close();
            Database.CloseConnection(conn);

            return brouwerijen;
        }
    }
}
