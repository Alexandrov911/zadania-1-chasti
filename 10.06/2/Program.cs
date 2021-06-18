using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            //2. Известны координаты на плоскости двух точек.
            // Составить программу вычисления расстояния между ними. 
            Console.Write("x1=");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("x2=");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("y1=");
            double y1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("y2=");
            double y2 = Convert.ToDouble(Console.ReadLine());

            double d = Math.Sqrt(Math.Pow(x1 - x2,2) + Math.Pow(y1 + y2,2));
            Console.WriteLine("d" + d);
            Console.ReadKey();

        }
    }
}
