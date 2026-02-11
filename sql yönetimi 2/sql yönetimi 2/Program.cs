using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sql_yönetimi_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***MOTOR YÖNETİM SİSTEMİ***");
            Console.WriteLine();
            Console.WriteLine();

            Console.Write("Değişim yapılacak motorun Id numarasını giriniz:");
            int idno = int.Parse(Console.ReadLine());  // p1

            /* değişim
            Console.Write("Değişim yapılacak motorun yeni adi:");
            string model = Console.ReadLine(); // p2 

            SqlConnection connection = new SqlConnection("Data Source=.; initial catalog=yenic#; integrated security=True"); // önce sql bağlantısı kuruldu
            connection.Open();

            SqlCommand command = new SqlCommand("Update tablo2 set motormodel=@p2 where motorId=@p1", connection);

            command.Parameters.AddWithValue("@p1", idno);
            command.Parameters.AddWithValue("@p2", model);*/

            SqlConnection connection = new SqlConnection("Data Source=.; initial catalog=yenic#; integrated security=True"); // önce sql bağlantısı kuruldu
            connection.Open();

            SqlCommand command = new SqlCommand("Delete From tablo2 where motorId=@p1", connection);
            command.Parameters.AddWithValue("@p1", idno);
            command.ExecuteNonQuery();

            connection.Close();

            Console.WriteLine("Değiştirildi !");
        }
    }
}
