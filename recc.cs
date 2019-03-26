using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static double fx(double x)
        {
            return Math.Sqrt(x) + 1 - 5 * Math.Cos(x);
        }
        static double fffx(double x)
        {
            return -1 / (4 * Math.Sqrt(x * x * x)) + 5 * Math.Cos(x);
        }
        static double xnull(double a, double b)
        {
            if (fx(a) * fffx(a) > 0)
            {
                return b;
            }
            else
            {
                return a;
            }
        }
        static double cstart(double a, double b)
        {
            if (fx(a) * fffx(a) > 0)
            {
                return a;
            }
            else
            {
                return b;
            }
        }
        static double xnplus1(double x, double c)
        {
            return x - ((fx(x) * (x - c)) / (fx(x) - fx(c)));
        }

        static void Main(string[] args)
        {

        }
    }
}
