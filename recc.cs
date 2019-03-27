using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

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
        static double xnplus1(double x, double c, double e)
        {
            if (Math.Abs(x - ((fx(x) * (x - c)) / (fx(x) - fx(c))) - x) > e)
            {
                return x - ((fx(x) * (x - c)) / (fx(x) - fx(c)));
                x = x - ((fx(x) * (x - c)) / (fx(x) - fx(c)));
                xnplus1(x, c, e);
            }
            else return x;
        }
        static void Main(string[] args)
        {
            StreamReader fin = new StreamReader("Inlet.in");
            StreamWriter fout = new StreamWriter("Outlet.out");
            string[] input = fin.ReadLine().Split(' ');
            double a = Convert.ToDouble(input[0]);
            double b = Convert.ToDouble(input[1]);
            double e = Convert.ToDouble(input[2]);
            double x = xnull(a, b);
            double c = cstart(a, b);
            double ans = xnplus1(x, c, e);
            fout.WriteLine(ans);
            fout.Close();
        }
    }
}