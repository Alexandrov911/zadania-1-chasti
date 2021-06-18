using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._06
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Даны стороны прямоугольника. Найти его периметр и длину диагонали.
            Console.WriteLine("Введите число a");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число b");
            double b = Convert.ToDouble(Console.ReadLine());
            double p = 2 * (a + b);
            double d = Math.Sqrt(Math.Sqrt(a) + Math.Sqrt(b));
            Console.WriteLine("Периметр равен " + p);
            Console.WriteLine("Диагональ равна" + d);
            Console.ReadKey();
        } 
    }
}
