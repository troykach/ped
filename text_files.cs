using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace text_files
{
    class text_files
    {
        static void Main(string[] args)
        {
            StreamReader infile = new StreamReader("inlet.in");
            StreamWriter outfile = new StreamWriter("outlet.out");
            string str0;
            string str = " ";
            int count = 0;
            string searchitem0;
            searchitem0 = infile.ReadLine();
            char searchitem = searchitem0[0];
            while ((str0 = infile.ReadLine()) != null)
            {
                count = 0;
                str = str0;
            }
            int i;
            int j = 0;
            string q = "  ";
            char[] founditems = new char[] {};
            for (i=0; i<str.Length; i++)
            {
                if ((str[i] == searchitem) && ((i+1)<str.Length))
                {
                    count = 1;
                    for(int k = i+1;k<str.Length;k++)
                    {
                        Array.Resize(ref founditems, founditems.Length + 1);
                        founditems[j] = str[k];
                        j++;
                        Array.Resize(ref founditems, founditems.Length + 1);
                        founditems[j] = ' ';
                        j++;
                    }
                    break;
                }
            }
            if (count == 1)
            {
                outfile.Write(founditems);
                outfile.Close();
            }
            else
            {
                outfile.Write(count);
                outfile.Close();
            }
        }
    }
}
