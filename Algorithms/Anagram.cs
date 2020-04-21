using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class Anagram
    {

        public static void main(string[] args)
        {
           Console.Write( anagram("asdfjoieufoa"));

            Console.ReadKey();
        }

        static int anagram(string s)
        {

            if (s.Length % 2 != 0)
            {
                return -1;
            }
            else
            {
                int count = 0;
                int middle = s.Length / 2;
                var a1 = s.Substring(0, middle).ToCharArray();
                var a2 = s.Substring(middle, middle);

                for (int i = 0; i < a1.Length; i++)
                {
                    if (a2.IndexOf(a1[i]) == -1)
                    {
                        count++;
                    }
                    else
                    {

                        a2 = a2.Substring(0, a2.IndexOf(a1[i])) + a2.Substring(a2.IndexOf(a1[i])+1);
                    }
                }
                return count;
            }


        }

    }

    
}
