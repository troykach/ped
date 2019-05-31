using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace recc2
{
    class recc2
    {
        public static int gl = 0;
        static int Recc(string[] input, int i, int j, int min)
        {

            if (input[i].Length<min)
            {
                min = input[i].Length;
            }
            if (i < input.Length-1)
            {
                i++;
                Recc(input, i, j,min);
            }
            if (min < gl)
            {
                gl = min;
            }
            return min;
        }
        static void Main(string[] args)
        {
            StreamReader infile = new StreamReader("inlet.in");
            StreamWriter outfile = new StreamWriter("outlet.out");
            string[] input = new string[] { };
            string str = "";
            int count = 0;
            int i = 0;
            int j = 0;
            int min = 0;

            while ((str = infile.ReadLine()) != null)
            {
                Array.Resize(ref input, input.Length + 1);
                input[i] = str;
                i++;
            }
            min = input[0].Length;
            gl = min;
            i = 0;
            j = 0;
            min = Recc(input, i, j, min);
            count = 1;
            for (i=0;i<input.Length;i++)
            {
                if(input[i].Length==gl)
                {
                    count = count-1;
                }
            }
            if (count<=-1)
            {
                outfile.Write("-1");
                outfile.Close();
            }
            else
            {
                outfile.Write(gl);
                outfile.Close();
            }
        }
    }
}
