using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1 task
            Console.WriteLine("1 task");

            double R, S, L;
            Console.WriteLine("Введите длину окружности");
            L = Convert.ToDouble(Console.ReadLine());
            R = L / (2 * Math.PI);
            Console.WriteLine("Радиус равен:");
            Console.WriteLine(R);
            S = Math.Pow(L, 2) / (4 * Math.PI);
            Console.WriteLine("Площадь равна:");
            Console.WriteLine(S);
            //2 task 

            Console.WriteLine("2 task");

            int x1, x2, y1, y2;
            Console.WriteLine("Введите точки x1");
            x1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Введите точки y1");
            y1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Введите точки x2");
            x2 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Введите точки y2");
            y2 = Convert.ToInt16(Console.ReadLine());

            int Length, High;
            if (x1 >= x2)
                Length = x1 - x2;
            else
                Length = x2 - x1;
            if (y1 >= y2)
                High = y1 - y2;
            else
                High = y2 - y1;
            int Perimetr, Square;
            Perimetr = 2 * Length + 2 * High;
            Square = Length * High;
            Console.WriteLine("Периметр равен:");
            Console.WriteLine(Perimetr);
            Console.WriteLine("Площадь равна:");
            Console.WriteLine(Square);

            //3 task
            Console.WriteLine("3 task");

            int x3, y3;
            Console.WriteLine("Введите точки x1");
            x1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Введите точки y1");
            y1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Введите точки x2");
            x2 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Введите точки y2");
            y2 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Введите точки x3");
            x3 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Введите точки y3");
            y3 = Convert.ToInt16(Console.ReadLine());

            double a, b, c;
            a = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            b = Math.Sqrt(Math.Pow((x3 - x2), 2) + Math.Pow((y3 - y2), 2));
            c = Math.Sqrt(Math.Pow((x1 - x3), 2) + Math.Pow((y1 - y3), 2));

            double s, p;
            p = (a + b + c) / 2;
            double pa, pb, pc;
            pa = p - a;
            pb = p - b;
            pc = p - c;
            s = Math.Sqrt(p * pa * pb * pc);
            Console.WriteLine("Итоговая площадь равна: ");
            Console.WriteLine(s);
            Console.Read();
        }
    }
}
