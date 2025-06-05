using MySql.Data.MySqlClient;
using prjExtraOefBrouwerij.Helper;
using prjExtraOefBrouwerij.Model;
using System;
using System.Collections.Generic;
using System.Data;
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
    }
}
