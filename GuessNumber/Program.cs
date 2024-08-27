using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionThree
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sayı tahmin
            Random say = new Random();
            int rastsay = say.Next(0,50);
            int sayi;
            do
            {
                Console.Write("Bir sayı girin: ");
                sayi = Convert.ToInt32(Console.ReadLine());
                if (sayi > rastsay)
                {
                    Console.WriteLine("Birazdaha Büyük girmelisin");
                   
                }
                else if (sayi < rastsay)
                {
                    Console.WriteLine("Birazdaha Küçük girmelisin");
                }
                else
                {
                    Console.WriteLine("Tebrikler");
                }

            } while (sayi!=rastsay);
            Console.ReadKey();

        }
    }
}
