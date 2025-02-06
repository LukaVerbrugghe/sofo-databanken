using System;
using System.Collections.Generic;
using System.Data;
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

        public static List<Bier> OphalenBieren(string Brouwerij)
        {
            //je geeft een parameter mee om de bieren van die geselecteerde brouwerij op te vragen
            List<Bier> Bieren = new List<Bier>();

            //sql statement
            string sql = "SELECT * FROM bier WHERE brouwerij=@brouwerij";

            //verbinding maken met de database
            MySqlConnection conn = Database.MaakVerbinding();
            MySqlCommand cmd = new MySqlCommand( sql, conn);
            cmd.CommandType = System.Data.CommandType.Text;

            //parameter niet vergeten (!!!)
            cmd.Parameters.AddWithValue("@brouwerij", Brouwerij);
            
            //reader nodig om de gegevens op te halen, want er zijn meerdere gegevens die we willen ophalen uit de database
            MySqlDataReader r = cmd.ExecuteReader();

            //reader in onze list steken met ieder item als een object (!!!)
            //IDatarecord nodig
            while(r.Read())
            {
                Bieren.Add(Create(r));
            }
            r.Close();
            Database.CloseConnection(conn);
            return Bieren;
        }

        //deze methode wordt gebruikt door ophalenbieren
        public static Bier Create(IDataRecord record)
        {
            return new Bier()
            {
                Biernaam = record["biernaam"].ToString(),
                Brouwerij = record["brouwerij"].ToString(),
                Alcohol = Convert.ToDecimal(record["alcohol"].ToString()),
                Kleur = record["kleur"].ToString()
            };
        }

        //zorgen dat je een vier kan verwijderen
        public static void Verwijder(Bier bier)
        {
            //verbinding maken met de databank
            MySqlConnection conn = Database.MaakVerbinding();

            //sql statement
            string sql = "DELETE FROM bier WHERE biernaam = @biernaam";

            //cmd
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Parameters.AddWithValue("@biernaam", bier.Biernaam);

            //commando uitvoeren
            cmd.ExecuteNonQuery();

            Database.CloseConnection(conn);
        }

        public static void Toevoegen(Bier bier)
        {
            MySqlConnection conn = Database.MaakVerbinding();
            string sql = "INSERT INTO bier (biernaam, brouwerij, kleur, alcohol) VALUES (@biernaam, @brouwerij, @kleur, @alcohol)";
            MySqlCommand cmd = new MySqlCommand( sql, conn);
            cmd.CommandType=System.Data.CommandType.Text;

            cmd.Parameters.AddWithValue("@biernaam", bier.Biernaam.ToString());
            cmd.Parameters.AddWithValue("@brouwerij", bier.Brouwerij.ToString());
            cmd.Parameters.AddWithValue("@kleur", bier.Kleur.ToString());
            cmd.Parameters.AddWithValue("@alcohol", bier.Alcohol.ToString());

            cmd.ExecuteNonQuery();

            Database.CloseConnection(conn);
        }
    }
}
