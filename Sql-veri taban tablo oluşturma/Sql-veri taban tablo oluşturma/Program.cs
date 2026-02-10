using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sql_veri_taban_tablo_oluşturma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---YEMEK MENÜSÜ---");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("-------------------------");

            Console.WriteLine("1-ÇORBALAR");
            Console.WriteLine("2-ANA YEMEKLER");
            Console.WriteLine("3-TATLILAR");

            Console.WriteLine("-------------------------");


            int number;
            Console.Write("hangi yemek türünü istersin:");
            number = int.Parse(Console.ReadLine());


            SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=yenic#;Integrated Security=True");
            connection.Open();

            SqlCommand command = new SqlCommand("Select * From tablo1", connection);

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();

            adapter.Fill(dataTable);
            connection.Close();

            foreach (DataRow row in dataTable.Rows)
            {

                foreach (var item in row.ItemArray)
                {
                    Console.WriteLine(item.ToString());
                }
            }
        }
    }
}
