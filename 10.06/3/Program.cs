using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            //3.Известна стоимость 1 кг конфет, печенья и яблок. 
            //Найти стоимость всей покупки, если купили x кг конфет, у кг печенья и z кг яблок.
            Console.WriteLine("Введите число x кг");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число y кг");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число z кг");
            int z = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите стоимость a");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите стоимость b");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите стоимость c");
            int c = Convert.ToInt32(Console.ReadLine());

            int b1 = (x * a) + (y * a) + (z * a);
            Console.WriteLine("Стоимость всей покупки " + b1);
            Console.ReadKey();
        }
    }
}
