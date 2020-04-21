using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class GreedyFlorist
    {

        public static void main(string[] args)
        {
          int k=  getMinimumCost(3, new int[5] { 1, 3, 5, 7, 9 });
            Console.Write(k);
            Console.ReadKey();
        }

        static int getMinimumCost(int k, int[] c)
        {
            int min = 0;
            if (k == c.Length)
            {
                for (int i = 0; i < c.Length; i++)
                {
                    min = min + c[i];
                }
            }
            else
            {
                int per = k;
                int counter = 0;
              
                for (int i = 0; i < c.Length; i++)
                {
                    for (int j = i + 1; j < c.Length; j++)
                    {
                        if (c[i] < c[j])
                        {
                            int temp = c[i];
                            c[i] = c[j];
                            c[j] = temp;
                        }
                    }
                    if (k == 0)
                    {
                        counter++;
                        k = per;


                    }
                    min = min + ((counter + 1) * c[i]);
                    k--;

                }

            }

            return min;

        }

    }
}
