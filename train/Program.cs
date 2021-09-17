using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите числа");
           double p = Convert.ToDouble(Console.ReadLine());
          double  t = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Сумма равна " + (p + t));
            Console.WriteLine("Разность равна " + (p - t));
            Console.WriteLine("Произведение равно " + p * t);
            Console.WriteLine("Частное равно " + p / t);
        }

    }
}