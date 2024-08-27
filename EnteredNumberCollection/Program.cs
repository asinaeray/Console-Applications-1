using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionsTryConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //Girilen sayıları topalama
            Console.WriteLine("İlk Sayı: ");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("İkinci Sayı: ");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            int topla = sayi1 + sayi2;

            Console.WriteLine("Cevap= "+topla);
            Console.ReadKey();
        }
    }
}
