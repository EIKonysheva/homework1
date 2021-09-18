using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("S.1.1"); 
            double v = 2.46465436543;
            double g = Math.Round(v, 2);
            Console.WriteLine(g);

            Console.WriteLine("S.1.2"); 
            double e = Math.E;
            double d = Math.Round(e, 2);
            Console.WriteLine(d);

            Console.WriteLine("S.1.3");
            Console.WriteLine("Вы ввели число");
            Console.ReadLine();

            Console.WriteLine("S.1.4");
            Console.WriteLine("Вы ввели число");
            Console.ReadLine();
            Console.WriteLine("Вот какое число Вы ввели");

            Console.WriteLine("S.1.5");
            int k = 1;
            int l = 13;
            int m = 49;
            Console.WriteLine(k + " " + l + " " + m);

            Console.WriteLine("S.1.6");
            k = 7;
             l = 15;
             m = 100;
            Console.WriteLine( k + "  " + l + "  " + m);

            Console.WriteLine("S.1.7");
            Random rnd = new Random();
            k = rnd.Next();
            l = rnd.Next();
            m = rnd.Next();
            Console.WriteLine(k + "  " + l + "  " + m);

            Console.WriteLine("S.1.8");
            k = rnd.Next();
             l = rnd.Next();
             m = rnd.Next();
             int n = rnd.Next();
            Console.WriteLine(k + " " + l + " " + m + " " + n);

            Console.WriteLine("S.1.9");
            Console.WriteLine(50);
            Console.WriteLine(10);

            Console.WriteLine("S.1.10");
            Console.WriteLine(5);
            Console.WriteLine(10);
            Console.WriteLine(21);

            Console.WriteLine("S.1.11");
            k = rnd.Next();
            l = rnd.Next();
            m = rnd.Next();
            n = rnd.Next();
            Console.WriteLine(k);
            Console.WriteLine(l);
            Console.WriteLine(m);
            Console.WriteLine(n);

            Console.WriteLine("S.1.12");
            Console.WriteLine("5 10");
            Console.WriteLine("7 см");

            Console.WriteLine("S.1.13");
            Console.WriteLine("2 кг");
            Console.WriteLine("13 17");

            Console.WriteLine("S.2.1.a");
            int x = Convert.ToInt32(Console.ReadLine());
            int result = 7 * x * x + 3 * x + 6;
            Console.WriteLine("y = 7x^2 + 3x + 6 = " + result);
            
            Console.WriteLine("S.2.1.b");
            //x = 12a2 + 7a + 12
            int a = Convert.ToInt32(Console.ReadLine());
             result = 12 * a * a + 7 * a + 12;
            Console.WriteLine("x = 12a^2 + 7a + 12 = " + result);


            Console.WriteLine("S.2.2");
            //P = 4a
            double side = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("P = 4a = " + side * 4);

            Console.WriteLine("S.2.3");
            // D=2r
            double radius = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("D = 2r = " + radius * 2);

            Console.WriteLine("S.2.4");
            double h = Convert.ToDouble(Console.ReadLine());
            bool test = (h <= 0);
            if (test)
                Console.WriteLine("Значение высоты должно быть положительно");
            else
                Console.WriteLine(Math.Sqrt((6350 + h) * (6350 + h) - 6350 * 6350));


            Console.WriteLine("S.2.5");
            // V=a^3 S=4*a^2
            side = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("V = a^3 = " + Math.Pow (side, 3));
            Console.WriteLine("S = 4*a^2 = " + Math.Pow(side, 2)*4);

            Console.WriteLine("S.2.6");
            // L = 2πR S=πR²
            radius = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("L = 2*Pi*R = " + radius * 2 * Math.PI);

            Console.WriteLine("S.2.7");
            int n1, n2;
            n1 = Convert.ToInt32(Console.ReadLine());
            n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Среднее арифметическое = " , (n1 + n2)/2);
            Console.WriteLine("Среднее геометрическое = ", Math.Sqrt(n1 * n1 * n2 * n2));

            Console.WriteLine("S.2.8");
            int V, M;
            V = Convert.ToInt32(Console.ReadLine());
            M = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Плотность равна " + M / V);

            Console.WriteLine("S.2.9");
            int S, Q;
            S = Convert.ToInt32(Console.ReadLine());
            Q = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Плотность населения равна " + S / Q);

            Console.WriteLine("S.2.10");
            //cx+b=0 
            string c, b;
            c = Convert.ToString(Console.ReadLine());
            b = Convert.ToString(Console.ReadLine());
            Console.WriteLine(a + "x + " + b + " =0");
            int c1 = int.Parse(c);
            int b1 = int.Parse(b);
            Console.WriteLine("x = " + -b1 / c1);

            Console.WriteLine("S.2.11");
            int A, B;
            A = Convert.ToInt32(Console.ReadLine());
            B = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Гипотенуза равна " + Math.Sqrt(A*A + B*B));

            Console.WriteLine("S.2.12");
            //S=π(R^2-r^2)
           int R = Convert.ToInt32(Console.ReadLine());
           int r = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Площадь кольца равна " + Math.PI*(R*R-r*r));

            Console.WriteLine("S.2.13");
            A = Convert.ToInt32(Console.ReadLine());
            B = Convert.ToInt32(Console.ReadLine());
            int C = Convert.ToInt32((Math.Sqrt(A * A + B * B))); // C-гипотенуза
            Console.WriteLine("Периметр равен " + (A + B + C));

            Console.WriteLine("S.2.13А");
             n1 = Convert.ToInt32(Console.ReadLine());
             n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Среднее арифметическое = " + ((Math.Abs(n1) + Math.Abs(n2)) / 2));
            Console.WriteLine("Среднее геометрическое = ", Math.Sqrt(n1 * n1 * n2 * n2));

            Console.WriteLine("S.2.14");
            Console.WriteLine("Введите значение оснований");
            double p = Convert.ToDouble(Console.ReadLine());
            double t = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение высоты");
            double j = Convert.ToInt32(Console.ReadLine());
            double a1 = Math.Sqrt(((p - t) / 2) * ((p - t) / 2) + j * j);
            Console.WriteLine("P = a + b + c + d = " + (p + t + a1 + a1));


            Console.WriteLine("S.2.15");
            Console.WriteLine("Введите числа");
             p = Convert.ToDouble(Console.ReadLine());
             t = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Сумма равна " + (p+t));
            Console.WriteLine("Разность равна " + (p-t));
            Console.WriteLine("Произведение равно " + p*t);
            Console.WriteLine("Частное равно " + p/t );



            Console.WriteLine("S.2.16");
            Console.WriteLine("Введите числа");
            p = Convert.ToDouble(Console.ReadLine());
            t = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Сумма равна " + (p + t));
            Console.WriteLine("Разность равна " + (p - t));
            Console.WriteLine("Произведение равно " + p * t);
            Console.WriteLine("Частное равно " + p / t);

            Console.WriteLine("S.2.17");
            Console.WriteLine("Введите значения сторон параллепипеда");
            p = Convert.ToDouble(Console.ReadLine());
            t = Convert.ToDouble(Console.ReadLine());
            j = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Объем равен " + p*t*j);
            Console.WriteLine("Площадь боковой поверхности равна " + (2*p*j + 2*j*t + 2*p*t));

            Console.WriteLine("S.2.18");
            Console.WriteLine("Повтор 2.14");

            Console.WriteLine("S.2.19");
            Console.WriteLine("Введите значения оснований и угла");
            p = Convert.ToDouble(Console.ReadLine());
            t = Convert.ToDouble(Console.ReadLine());
            j = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(  "Площадь трапеции равна = " + (p*t)/Math.Sin(j));

            Console.WriteLine("S.2.20");
            double x1, x2, x3, y1, y2, y3, a12, a23, a31;
            Console.WriteLine("Введите координаты первой точки");
            x1 = Convert.ToDouble(Console.ReadLine());
            y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координаты второй точки");
            x2 = Convert.ToDouble(Console.ReadLine());
            y2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координаты третьей точки");
            x3 = Convert.ToDouble(Console.ReadLine());
            y3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Площадь треугольника равна = " + (Math.Abs((x1 - x3) * (y2 - y3) - (x2 - x3) * (y1 - y3)) / 2));
            a12 = Math.Sqrt((x2 * x2 - x1 * x1) + (y2 * y2 - y1 * y1));
            a23 = Math.Sqrt((x3 * x3 - x2 * x2) + (y3 * y3 - y2 * y2));
            a31 = Math.Sqrt((x3 * x3 - x1 * x1) + (y3 * y3 - y1 * y1));
            Console.WriteLine("Периметр треугольника равен " + (a12 + a23 + a31));

            

        }
    }
}



