using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6
{
    class Program
    {
        static void Main(string[] args)
        {
            //часть 2
            //1.Дано трехзначное число. Верно ли, что все его цифры одинаковые?
            Console.WriteLine("введите трехзначное число");
            double a = Convert.ToDouble(Console.ReadLine());
            double x = 0;
            double b = 0;
            double c= 0;

            if (a <= 999)
            {
                x = (a / 100) % 10;
                b = (a / 10) % 10;
                c = (a / 1) % 10;

                if (a == c && b == c && x == c)
                {
                    Console.WriteLine("Все цифры одинаковы");
                }
                else
                {
                    Console.WriteLine("Все цифры разные");
                }
                Console.ReadKey();
            }
            
        }
    }
}
