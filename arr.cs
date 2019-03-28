using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ConsoleApp2
{
    class Pr
    {
    static void Main(string[] args)
    {
            // 1 2 3  
            // 8 9 4  
            // 7 6 5  
            //int n = Convert.ToInt32(Console.ReadLine());
            StreamReader fin = new StreamReader("Inlet.in");
            StreamWriter fout = new StreamWriter("Outlet.out");
            string input = fin.ReadLine();
            int n = Convert.ToInt32(input);
            int[,] a = new int[n, n];
        int printValue = 1;
        int c1 = 0, c2 = n - 1;
        while (printValue <= n * n)
        {
            //Right Direction Move  
            for (int i = c1; i <= c2; i++)
                a[c1, i] = printValue++;
            //Down Direction Move  
            for (int j = c1 + 1; j <= c2; j++)
                a[j, c2] = printValue++;
            //Left Direction Move  
            for (int i = c2 - 1; i >= c1; i--)
                a[c2, i] = printValue++;
            //Up Direction Move  
            for (int j = c2 - 1; j >= c1 + 1; j--)
                a[j, c1] = printValue++;
            c1++;
            c2--;
        }
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                    //Console.Write(a[i, j] + "\t");
                    fout.Write(a[i, j]);
                    fout.Write(' ');
            }
                //Console.WriteLine();
                fout.WriteLine();
        }
            fout.Close();
        //Console.Read();
    }
}
}  