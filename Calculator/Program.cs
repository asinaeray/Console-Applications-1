using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionFour
{
    class Program
    {
        static void Main(string[] args)
        {
            string devam;
            
                do
                {
                    Console.Write("İlk Sayı: ");
                    int sayi1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("İkinci Sayı: ");
                    int sayi2 = Convert.ToInt32(Console.ReadLine());
                    int topla = sayi1 + sayi2;
                    int cikar = sayi1 - sayi2;
                    int carp = sayi1 * sayi2;
                    int bol = sayi1 / sayi2;
                    Console.WriteLine("İşlem Giriniz(+,-,*,/): ");
                    string islem = Console.ReadLine();
                    if (islem == "+")
                    {
                        Console.Write("Cevap: " + topla);
                    }
                    else if (islem == "-")
                    {
                        Console.WriteLine("Cevap: " + cikar);
                    }
                    else if (islem == "*")
                    {
                        Console.WriteLine("Cevap: " + carp);
                    }
                    else if (islem == "/")
                    {
                        if (sayi2 != 0)
                        {
                            Console.WriteLine("Cevap: " + bol);
                        }
                        else
                        {
                            Console.WriteLine("Hata");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Hata");
                    }
                    Console.WriteLine("Devam Etmek İstermisiniz? (E/H): ");
                    devam = Console.ReadLine();
                } while (devam == "E" || devam == "e");
                
        
    
            Console.ReadKey();
        }
    }
}
