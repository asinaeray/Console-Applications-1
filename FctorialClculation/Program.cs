using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QestionTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Faktöriyel hesaplama
            Console.Write("Bir sayı giriniz : ");
            int n = Convert.ToInt32(Console.ReadLine());
            int fakt = 1;
            for (int i = 1; i <= n; i++)
            {
                fakt *= i;
            }

            Console.Write(n+" != "+fakt);
            Console.ReadKey();
            
        }
    }
}
