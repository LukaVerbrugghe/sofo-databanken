using MySql.Data.MySqlClient;
using prjApollo.Helper;
using prjApollo.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjApollo.DA
{
    public class LeveranciersDA
    {
        public static List<Model.Leveranciers> getLeveranciers()
        {
            List<Leveranciers> leveranciersList = new List<Model.Leveranciers>();

            //sql statement
            string sql = "SELECT * FROM tblleveranciers";

            //verbinding met de databank openen
            MySqlConnection conn = Database.MaakVerbinding();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.CommandType = System.Data.CommandType.Text;

            //we hebben geen parameters

            MySqlDataReader r = cmd.ExecuteReader();

            //gegevens uit de reader in de list steken
            while (r.Read()) {
                leveranciersList.Add(Create(r));
            }
            r.Close();
            conn.Close();
            return leveranciersList;
        }
        public static Leveranciers Create(IDataRecord record)
        {
            return new Leveranciers
            {
                leveranciernummer = Convert.ToInt32(record["leveranciernummer"]),
                firmanaam = Convert.ToString(record["firmanaam"]),
                adres = Convert.ToString(record["adres"]),
                postnr = Convert.ToString(record["postnr"]),
                gemeente = Convert.ToString(record["gemeente"])
            };
        }
    }
}
