using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class Kadane_s_Algorithm
    {

        public static void Main(string[] args)
        {
            int[] a = { -2, -3, 4, -3, 10, 1, 5, -3 };
            Console.Write("Maximum contiguous sum is " +
                                    maxSubArraySum(a));
        }

        static int maxSubArraySum(int[] a)
        {
            int size = a.Length;
            int max_so_far = int.MinValue,
                max_ending_here = 0;

            for (int i = 0; i < size; i++)
            {
                max_ending_here = max_ending_here + a[i];

                if (max_so_far < max_ending_here)
                    max_so_far = max_ending_here;

                if (max_ending_here < 0)
                    max_ending_here = 0;
            }

            return max_so_far;
        }
    }
}
