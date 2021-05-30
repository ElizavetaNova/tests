using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double summ;

            Console.WriteLine("Hello World!");
            Equation e = new Equation();
            e.EquationRezult(1, 5, -6);
        }
        //public static void Equation(double a, double b, double c)
        //{
        //    double x;
        //    double diskr;
        //    diskr = Math.Pow(b, 2) + 4 * a * c;
        //    if (diskr < 0)
        //        Console.WriteLine("Дискрименант меньше нуля. Корней нет");

        //    if (diskr == 0)
        //    {
        //        x = -b / (2 * a);
        //        Console.WriteLine("Ответ x = " + x);
        //    }
        //    if (diskr > 0)
        //    {
        //        double x1 = (-b - Math.Sqrt(diskr)) / (2 * a);
        //        double x2 = (-b + Math.Sqrt(diskr)) / (2 * a);
        //        Console.WriteLine("Ответ x1 = " + x1 + " x2 = " + x2);

        //    }


        //}
    }
}
