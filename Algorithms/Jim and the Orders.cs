using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class Jim_and_the_Orders
    {

        public static void main(string[] args)
        {
            int[][] a = new int[2][];
            a[0] = new int[2] { 1,1};
            a[1] = new int[2] { 1,1 };
            
            int[] result = jimOrders(a);
            Console.ReadKey();
        }

        static int[] jimOrders(int[][] orders)
        {
            int[] res = new int[orders.Length];
            int[] result = new int[orders.Length];
            for (int i = 0; i < orders.Length; i++)
            {
                res[i] = orders[i][0] + orders[i][1];
            }
            int pointer = orders.Length;
            for (int i = 0; i < res.Length; i++)
            {
                int min = 0;
                int pos = 0;
                for (int j = 0; j < res.Length; j++)
                {
                    if (res[j] != -1)
                    {
                        if (min == res[j])
                        {
                            if (pos<j)
                            {
                                pos = j;
                            }
                        }
                        else if (min < res[j])
                        {
                            pos = j;
                            min = res[j];
                        }
                    }

                }
                res[pos] = -1;
                result[--pointer] = pos + 1;

            }

            return result;
        }
    }
    }
