using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex
{
    class Program
    {
        static void Main(string[] args)
        {
            //Методичка 2.1
            Console.WriteLine("2.1");
            Console.WriteLine("Введите ваше имя");
            string name;
            name = Console.ReadLine();
            Console.WriteLine("Привет, " + name + "!");

            //Методичка 2.2
            Console.WriteLine("2.2");
            Console.WriteLine("Введите 2 целых числа");
            int number1 = Convert.ToInt32(Console.ReadLine());
            int number2 = Convert.ToInt32(Console.ReadLine());
            //ввели 2 числа, конвертировали в инт;
            bool test = (number2 == 0);
            //проверка на 0;
            if (test)
                Console.WriteLine("на 0 делить нельзя");
            else
                Console.WriteLine(number1 / number2);

            //Методичка 2.3
            Console.WriteLine(2.3);
            char k = Console.ReadKey().KeyChar; 
            char symbol1 = char.ToLower(k);
            char symbol2;
            if (symbol1 == 'z')
                symbol2 = 'a';
            else
                symbol2 = (char)(((int)symbol1) + 1);

            Console.WriteLine();
            Console.WriteLine(symbol2);

            Console.WriteLine(2.4);
            //D=b^2 - 4ac
            int a, b, c;
            Console.WriteLine("Введите a, b и c");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            int D = b * b - 4 * a * c;
            if (D >= 0)
            {
                double x1 = ((-b + Math.Sqrt(D)) / 2 * a);
                double x2 = ((-b - Math.Sqrt(D)) / 2 * a);
                Console.WriteLine("x1 = " + x1 + "  x2 = " + x2);
            }
            else
                Console.WriteLine("Нет действительных корней");







        }

    }
}

