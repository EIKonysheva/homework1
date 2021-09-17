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
            Console.WriteLine("Введите ваше имя");
            string name;
            name = Console.ReadLine();
            Console.WriteLine("Привет, " + name + "!");

            //Методичка 2.2
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
            char input = Console.ReadKey().KeyChar;
            char letter = char.ToLower(input);
            char nextChar;
            if (letter == 'z')
                nextChar = 'a';
            else
                nextChar = (char)(((int)letter) + 1);

            Console.WriteLine();
            Console.WriteLine(nextChar);

        

        }

    }
}

