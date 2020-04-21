using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class Fibanocii
    {
        public static void main(string[] args)
        {
          int resul=  fibonacciModified(0, 1, 10);
            Console.Write(resul);
        }



            static int fibonacciModified(int t1, int t2, int n)
        {
            long[] all = new long[n + 1];
            all[0] = t1;
            all[1] = t2;
            for (int i = 2; i < n; i++)
            {
                all[i] = (long)all[i - 2] + (long)Math.Pow(all[i - 1], 2);
            }

            return (int)all[n - 1];



        }
    }
}
