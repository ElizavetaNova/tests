using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Equation
    {
        double a, b, c;
        public Equation() { }

        public double EquationRezult(double a, double b, double c )
        {
            double summ;
            double x;
            double diskr;
            diskr = Math.Pow(b, 2) - 4 * a * c;
           
            if (diskr == 0)
            {
                x = -b / (2 * a);
                Console.WriteLine("Ответ x = " + x);
                summ = x;
                return summ;
            }
            else if (diskr > 0)
            {
                double x1 = (-b - Math.Sqrt(diskr)) / (2 * a);
                double x2 = (-b + Math.Sqrt(diskr)) / (2 * a);
                Console.WriteLine("Ответ x1 = " + x1 + " x2 = " + x2);
                summ = x1 + x2;
                return summ;
            }
            else 
            {
                throw new Exception("dolboeb");   
            }


        }
    }
}
