using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace struct2
{
    struct pass
    {
        public int amount;
        public int weight;
    }
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader infile = new StreamReader("inlet.in");
            StreamWriter outfile = new StreamWriter("outlet.out");
            pass[] inputarr =new pass[] { };
            int k;
            k = Convert.ToInt32(infile.ReadLine());
            int i = 0;
            int j = 0;
            int fir = 0;
            int sec = 0;
            int count = -1;
            string inputstr = "";
            while ((inputstr = infile.ReadLine()) != null)
            {
                Array.Resize(ref inputarr, inputarr.Length + 1);
                inputarr[i].amount = Convert.ToInt32(inputstr);
                inputarr[i].weight = Convert.ToInt32(infile.ReadLine());
                i++;
            }
            for(i=1;i<inputarr.Length;i++)
            {
                for (j=0;j<i;j++)
                {
                    if ((inputarr[i].amount==inputarr[j].amount)&&(Math.Abs(inputarr[j].weight-inputarr[i].weight)<=k))
                    {
                        count++;
                        fir = i;
                        sec = j;
                    }
                }
            }
            if(count!=-1)
            {
                outfile.Write(sec+1);
                outfile.Write(' ');
                outfile.Write(fir+1);
                outfile.Close();
            }
            else
            {
                outfile.Write("-1");
                outfile.Close();
            }
        }
    }
}
