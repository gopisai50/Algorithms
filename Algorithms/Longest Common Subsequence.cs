using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class Longest_Common_Subsequence
    {

        public static void main(string[] args)
        {
            commonChild("abcdefghij","ecdgi");
        }


        static int commonChild(string s1, string s2)
        {
            char[] c1 = s1.ToCharArray();

            char[] c2 = s2.ToCharArray();

            int[,] res = new int[c1.Length + 1, c2.Length + 1];

            for (int i = 0; i <= c1.Length; i++)
            {
                for (int j = 0; j <= c2.Length; j++)
                {
                    if (i == 0 || j == 0)
                    {
                        res[i, j] = 0;
                    }
                    else if (c1[i - 1] == c2[j - 1])
                    {
                        res[i, j] = 1 + res[i - 1, j - 1];
                    }
                    else
                    {
                        res[i, j] = Math.Max(res[i - 1, j], res[i, j - 1]);
                    }
                }

            }

            return res[c1.Length, c2.Length];
        }
        }
}
