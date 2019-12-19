using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {

            //int[] a  = { 1,3,7 };
            //int[] b = {4,3,3};
            // output 5


            int[] a = { 1, 10 };
            int[] b = { 1, 5 };


            //output 7

            Dam(a, b);


        }

        public static void Dam(int[] a, int[] b)
        {
            int[] dum = new int[a[a.Length - 1]];
            for (int i = 0; i < a.Length; i++)
            {
                dum[a[i] - 1] = b[i];
            }
            int max = 0;
            for (int i = 0; i < a.Length - 1; i++)
            {

                int n = (a[i + 1] - a[i]) - 1;
                if (n > 1)
                {
                    max = findMax(a[i] - 1, a[i + 1] - 1, dum);

                }

            }
            Console.WriteLine(max);
            Console.ReadKey();
        }
        public static int findMax(int i, int j,  int[] dum)
        {
            int max = 0;


            int temp = i;

            while (i < j - 1)
            {

                //if (j - i == 1)
                //{
                //    dum[j - 1] = smallest(i, j) + 1;
                //    return dum[j - 1];
                //}
                int temp1 = dum[i + 1] = dum[i] + 1; //smallest(dum[i], dum[i + 2]);
                //if (temp1 > max)
                //{
                //    max = temp1;
                //}
                //int temp2 = dum[j - 1] = smallest(dum[j], dum[j - 2]);
                //if (temp2 > max)
                //{
                //    max = temp2;
                //}
                i++;
            }

            if (Math.Abs(dum[j] - dum[i]) > 1)
            {
                check(dum, temp, j);
            }

            for (int k = 0; k < dum.Length; k++)
            {
                if (dum[k] > max)
                {
                    max = dum[k];
                }
            }

            return max;
        }

        public static int smallest(int i, int j)
        {
            if (i == 0)
            {
                return j + 1;
            }
            if (j == 0)
            {
                return i + 1;
            }
            return i > j ? j : i;
        }

        public static void check(int[] dum, int i, int j)
        {

            if (Math.Abs(dum[j] - dum[j - 1]) <= 1)
            {
                return;
            }
            dum[j - 1] = dum[j] + 1;
            check(dum, i, j - 1);

        }
    }
}
