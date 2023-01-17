using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpPractice
{
    class PrimeN
    {
        /*public static void Main()
        {
            PrimeN pn = new PrimeN();
            pn.bracketsCheck("MONI(DScdnjdc)Dcjdsn[]{cjncjsdj}cdndkjd[");
            string strmain = "Life is good";
            string sub="is";
            Console.WriteLine(strmain.Contains(sub));

        }*/
        public void bracketsCheck(string str)
        {
            Dictionary<char,int> dict=new Dictionary<char,int>();
            char[] ch=str.ToCharArray();
            for(int i=ch.Length-1;i>=0;i--)
            {
                if (dict.ContainsKey(ch[i]))
                {
                    dict[ch[i]]++;
                }
                else
                {
                    dict.Add(ch[i], 1);
                }
            }
            foreach(var a in dict)
            {
                //if(a.G)
                Console.WriteLine(a.Key+" "+a.Value+"\n");
            }
            


        }
        
        public void prime()
        {
            string str = "monicAacinom";
            Console.WriteLine(str.ToLower().Distinct().ToArray());
            List<int> lst = new List<int>();
            lst.Add(1);
            lst.Add(2);
            lst.Add(3);
            lst.Add(4);
            lst.Add(5);
            lst.Add(6);
            Console.WriteLine(lst.Contains(4));
            for (int m = 1; m <= 100; m++)
            {
                int count = 0;
                for (int i = m; i >= 1; i--)
                {
                    if (m % i == 0)
                    {
                        count++;
                    }
                }
                if (count == 2)
                {
                    Console.WriteLine(m + "\n");
                }
            }
        }
    }
}
