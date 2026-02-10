using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace karar_yapilari
{
    internal class Program
    {
        static void Main(string[] args)
        {/*
            int number;
            Console.Write("sayi gir:");
            number = int.Parse(Console.ReadLine());

            if(number<5)
            {
                Console.WriteLine("sayi 5den kucuk");
            } else if (number>5)
            {
                Console.WriteLine("sayi 5den buyuk");
            } else
            {
                Console.WriteLine("sayi 5e eşittir");
            }
          --------------------------------------------
             int number;
            Console.Write("sayi gir");
            number = int.Parse(Console.ReadLine());

            if(number%2==0)
            {
                Console.Write("sayi cifttir");
            } else
            {
                Console.Write("sayi tektir");
            }
          */
            string name;
            Console.Write("takım kısaltmasını giriniz:");
            name = Console.ReadLine();

            switch (name)
            {
                case "gs": Console.WriteLine("galatasaray"); break;

                case "fb": Console.WriteLine("fenerbahce"); break;

                default: Console.WriteLine("yanlis secim"); break;
            }
        }
    }
}
