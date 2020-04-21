using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class Permuting_Two_Arrays
    {

        public static void main(string[] args)
        {

            string result=twoArrays(10, new int[3] { 2, 1, 3 }, new int[3] { 7, 8, 9 });

            Console.Write(result);
            Console.ReadKey();
        }

        static string twoArrays(int k, int[] A, int[] B)
        {
            bool flag = true;
            for (int i = 0; i < A.Length - 1; i++)
            {
                int min = A[i];
                int max = B[i];
                for (int j = i + 1; j < A.Length; j++)
                {
                    if (min > A[j])
                    {
                        int temp = A[j];
                        A[j] = min;
                        min = temp;

                    }
                    if (max < B[j])
                    {
                        int temp = B[j];
                        B[j] = min;
                        min = temp;

                    }
                }
                A[i] = min;
                B[i] = max;
                if (A[i] + B[i] >= k)
                {
                    flag = true;
                }
                else
                {
                    flag = false;
                    break;
                }
            }
            if (flag)
            {
                return "YES";
            }
            else
            {
                return "NO";
            }


        }
    }
}
