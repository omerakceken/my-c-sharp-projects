using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays_diziler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*dizi oluşturma şekilleri
            // string[] cities = new string[3];
            // string[] cities={"prag","atina"};

           /* char[] semboller = { '+', '-', '*', '/' };
            for (int i = 0; i < semboller.Length; i++)
            {
                Console.WriteLine(semboller[i]);
            }*/
            /*dizinin en buyuk elemani
            int[] dizi = { 5, 10, 15, 100, 30, 40 };
            int max = dizi[0];
            for (int i = 0; i < dizi.Length; i++)
            {
                if (dizi[i] > max)
                {
                    max = dizi[i];
                }
            }

            Console.WriteLine(max);*/
            /* sort metodu 
             int [] numbers={10,20,40,300,15,900};
            Array.Sort(numbers);
            for(int i=0;i <numbers.length;i++){
            Console.writeline(numbers[i]) // sayıarı küçükten büyüğe sıralar 
            }    
            
             Array.Reverse büyükten küçüğe aynı mantık 
             diziadi.length dizinin uzunluğunu ifade eder.

             */
            /* en buyuk en kucuk eleman
              int[] numbers = { 5, 10, 15, 100, 30, 40 };
              cw("en buyuk:" + numbers.max() + "en kucuk" + numbers.min() + );
             */
            /*dizideki elemanların tek ve cift tespiti
            int[] numbers = { 5, 10, 12, 11, 14, 15, 16, 17, 18, 19 };

            int i;
            for (i = 0; i < numbers.Length; i++)
            {
                if (numbers[i]%2==0)
                {
                    Console.WriteLine(numbers[i] + "sayisi çifttir");
                } else
                {
                    Console.WriteLine(numbers[i] + "sayisi tektir");

                }*/

            int[] numbers = { 2, 10, 5, 8, 22, 11, 1, 33 };
            Console.WriteLine("en büyük: " + numbers.Max() + " " + "en kucuk:" + numbers.Min() + " ");
        }
    }
}
