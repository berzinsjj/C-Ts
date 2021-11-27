using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class OtraKlase
    {
        public static List<Customer> Connect()
        {
            List<Customer> local = new List<Customer>();
            var settings = new MySqlConnectionStringBuilder
            {
                Server = "127.0.0.1",
                UserID = "root",
                Password = "0000",
                Port = 3306,
                Database = "majasdarbs"
            };

            try
            {
                MySqlConnection conn = new MySqlConnection(settings.ConnectionString);
                conn.Open();

                String readCommand = "SELECT vards, uzvards, telefons, epasts FROM Customers;";

                MySqlCommand m = new MySqlCommand(readCommand, conn);
                MySqlDataReader dataReader = m.ExecuteReader();

                while (dataReader.Read())
                {

                    Customer localObj = new Customer();
                    localObj.vards = dataReader["vards"].ToString();
                    localObj.uzvards = dataReader["uzvards"].ToString();
                    localObj.telefons = dataReader["telefons"].ToString();
                    localObj.epasts = dataReader["epasts"].ToString();
                    local.Add(localObj);
                }

                dataReader.Close();
                conn.Close();

            }
            catch
            {
                Console.WriteLine("Connection failed!");

            }

            return local;


        }
    }
}
