using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__sql_ekleme_guncelleme_silme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---Menü Değişiklik Sistemi---");
            Console.WriteLine();

            Console.WriteLine("--------------------------------");

            /* kategori ve ürün ekleme işlemleri
            Console.Write("Eklemek İstediğiniz Kategori Adı:");
            string categoryName = Console.ReadLine();


            Console.Write("Eklemek İstediğiniz Yemek Adı:");
            string foodName = Console.ReadLine();

            Console.WriteLine("--------------------------------");

            SqlConnection connection = new SqlConnection("Data Source=.;initial catalog=yenic#;integrated security=true");

            connection.Open();

            SqlCommand command = new SqlCommand("insert into tablo1 (categoryName , foodName) values (@p1, @p2)", connection);

            command.Parameters.AddWithValue("@p1", categoryName);
            command.Parameters.AddWithValue("@p2", foodName);
            command.ExecuteNonQuery();
            connection.Close();

            Console.Write("eklendi.");*/

            /*ürün listeleme


            SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=yenic#;Integrated Security=True");
            connection.Open();

            SqlCommand command = new SqlCommand("Select * From tablo1", connection);

            SqlDataAdapter adapter = new SqlDataAdapter(command); // veri yazdirmada datadapter kullan
            DataTable dataTable = new DataTable();

            adapter.Fill(dataTable);// veriler burada tutulur
            connection.Close(); 

            foreach (DataRow row in dataTable.Rows) // bu döngüde satır inxelenir
            {

                foreach (var item in row.ItemArray) // bu döngüde satır içeriği incelenir
                {
                    Console.Write(item.ToString() + " " );
                }
                Console.WriteLine();
            }*/

            /* ürün silme

            Console.Write("silinecek ürünün id gir:");
            int categoryId=int.Parse(Console.ReadLine());

            SqlConnection connection = new SqlConnection("Data Source=.;initial catalog=yenic#;integrated security=True");
            connection.Open();

            SqlCommand command = new SqlCommand("Delete From tablo1 where categoryId=@CategoryId",connection);
            command.Parameters.AddWithValue("@CategoryId", categoryId);
            command.ExecuteNonQuery();



            connection.Close();*/

            /* urun değişimi
            Console.Write("Değişim yapmak istediğiniz ürünün id no:");
            int idNo = int.Parse(Console.ReadLine());

            Console.Write("Ürünün yeni adı:");
            string yeniAd = Console.ReadLine();


            SqlConnection connection = new SqlConnection("Data Source=.;initial catalog=yenic#;integrated security=True");
            connection.Open();
            // DOĞRUSU: "foodName" sütununu değiştir, "categoryId" sütununa göre bul.
            // YANLIŞIN: "Update tablo1 set @foodName=yeniAd where idNo..." (SQL bunu anlamaz)

            // DOĞRUSU: "foodName" sütununu değiştir, "categoryId" sütununa göre bul.
            // YANLIŞIN: "Update tablo1 set @foodName=yeniAd where idNo..." (SQL bunu anlamaz)

            SqlCommand command = new SqlCommand("Update tablo1 Set foodName=@p1 Where categoryId=@p2", connection);

            // @p1 kutusuna C#'taki 'yeniAd' değişkenini koy
            command.Parameters.AddWithValue("@p1", yeniAd);

            // @p2 kutusuna C#'taki 'idNo' değişkenini koy
            command.Parameters.AddWithValue("@p2", idNo);

            command.ExecuteNonQuery();

            connection.Close();

            Console.WriteLine("başarıyla değiştirildi."); */
        }
    }
}
