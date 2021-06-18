using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            //4.Известна стоимость монитора, системного блока, клавиатуры и мыши. 
            //Сколько будут стоить 3 компьютера из этих элементов? 
            Console.WriteLine("Введите стоимость монитора a");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите стоимость системного блока b");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите стоимость клавиатуры c");
            double c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите стоимость мыши d");
            double d = Convert.ToDouble(Console.ReadLine());
            double r = (a+b+c+d)*3;
            Console.WriteLine(r);
            Console.ReadKey();
        }
    }
}
