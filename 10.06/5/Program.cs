using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            //5.Возраст Тани — X лет, а возраст Мити — Y лет.
            // Найти их средний возраст, а также определить, 
            //на сколько отличается возраст каждого ребенка от среднего значения
            Console.WriteLine("Введите возраст Тани x");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите возраст Мити y");
            double y = Convert.ToDouble(Console.ReadLine());
            double f = (x + y) / 2;
            double t = x - f;
            double m = y - f;
            Console.WriteLine("Средний возраст Тани и Мити " + f);
            Console.WriteLine("Возраст Тани отличается от среднего на "+t);
            Console.WriteLine("Возраст Мити отличается от среднего на "+m);
            Console.ReadKey();



        }
    }
}
