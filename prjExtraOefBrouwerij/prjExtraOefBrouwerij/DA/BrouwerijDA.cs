using MySql.Data.MySqlClient;
using prjExtraOefBrouwerij.Helper;
using prjExtraOefBrouwerij.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace prjExtraOefBrouwerij.DA
{
    public class BrouwerijDA
    {
        public static List<Brouwerij> ophalenBrouwerijen()
        {
            List<Brouwerij> brouwerijen = new List<Brouwerij>();

            string sql = "SELECT id,Name,Email,Website,ImagesURL,Description_nl,Description_en FROM brouwerij";

            MySqlConnection conn = Database.MaakVerbinding();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.CommandType = System.Data.CommandType.Text;

            //geen parameters

            MySqlDataReader r = cmd.ExecuteReader();

            while (r.Read())
            {
                brouwerijen.Add(Create(r));
            }
            r.Close();
            conn.Close();
            return brouwerijen;
        }

        public static Brouwerij Create(IDataRecord record)
        {
            return new Brouwerij()
            {
                id = Convert.ToInt32(record["id"]),
                Name = record["Name"].ToString(),
                Email = record["Email"].ToString(),
                Website = record["Website"].ToString(),
                ImagesURL = record["ImagesURL"].ToString(),
                Description_nl = record["Description_nl"].ToString(),
                Description_en = record["Description_en"].ToString()
            };
        }

        public static Color pickRowColor(string imgurl)
        {
            if(imgurl == string.Empty)
            {
                return Color.Red;
            }
            else
            {
                return Color.Green;
            }
        }

        public static string returnDescriptionNL(int id)
        {
            string sql = "SELECT Description_nl FROM brouwerij WHERE id = @ID";

            MySqlConnection conn = Database.MaakVerbinding();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.AddWithValue("@ID", id.ToString());

            string result = cmd.ExecuteScalar().ToString();
            conn.Close();
            return result;
        }

        public static string returnDescriptionEN(int id)
        {
            string sql = "SELECT Description_en FROM brouwerij WHERE id = @ID";

            MySqlConnection conn = Database.MaakVerbinding();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.AddWithValue("@ID", id.ToString());

            string result = cmd.ExecuteScalar().ToString();
            conn.Close();
            return result;
        }

        public static void UpdateDescriptions(string descrNL, string descrEN)
        {
            MySqlConnection conn = Database.MaakVerbinding();
            string sql = "UPDATE brouwerij SET Description_en=@en, Description_nl=@nl";
            MySqlCommand cmd = new MySqlCommand( sql, conn);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.AddWithValue("@en",descrEN);
            cmd.Parameters.AddWithValue("@nl", descrNL);

            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
