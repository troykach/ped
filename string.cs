using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader finp = new StreamReader("Inlet.in");
            StreamWriter foutp = new StreamWriter("Outlet.out");
            int len = 0;
            int count1 = 0;
            int count2 = 0;
            int rep = 0;
            string str;
            while ((str = finp.ReadLine()) != null)
            {
                string[] inp = str.Split(' ');
                int arrlen = inp.Length;
                for (int i=0; i<arrlen; i++)
                {
                    if (inp[i].Length==len)
                    {
                        rep = -1;
                    }
                    if (inp[i].Length>len)
                    {
                        len = inp[i].Length;
                        rep = 0;
                        count2 = count1 + i + 1;
                    }
                    
                }
                count1 += inp.Length;
            }
            if (rep == -1)
            {
                foutp.Write(rep);
                foutp.Close();
            }
            if (rep == 0)
            {
                foutp.Write(count2);
                foutp.Close();
            }
        }
    }
}
