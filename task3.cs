using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            double k = Convert.ToDouble(input[0]);
            double x = Convert.ToDouble(input[1]);
            int n;
            double sum = 1;
            double obrfact = 1;
            for (n = 1; n <= k; n++)
            {
                obrfact /= n;
                sum += (Math.Cos(n * x) * obrfact);
            }
            Console.WriteLine(sum);
            
        }
    }
}
