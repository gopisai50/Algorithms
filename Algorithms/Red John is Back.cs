using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class Red_John_is_Back  //Sieve of Eratosthenes for Primes
    {

        public static void main(string[] args)
        {
            redJohn(7);
        }

        static int redJohn(int n)
        {

            int[] f = new int[n + 1];


            if (n >= 4)
            {
                f[0] = 1;
                f[1] = 1;
                f[2] = 1;
                f[3] = 1;
                f[4] = 2;
            }
            else
                return 0;
            for (int i = 5; i <= n; i++)
            {
                f[i] = f[i - 1] + f[i - 4];
            }
            bool[] prime = new bool[f[n] + 1];
            for (int k = 0; k < prime.Length; k++)
                prime[k] = true;
            prime[0] = false;
            prime[1] = false;
            int count = 0;
            for (int i = 2; i <= f[n]; i++)
            {

                if (prime[i] == true)
                {
                    count++;
                    for (int j = 2; j <= f[n] / i; j++)
                    {
                        prime[j * i] = false;
                    }
                }


            }
            return count;
        }

    }
}
