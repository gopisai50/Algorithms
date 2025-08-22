using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class Kadane_s_Algorithm
    {

        public static void main(string[] args)
        {
            int[] a = { -2, -3, 4, -3, 10, 1, 5, -3 };

            int[] nums = { 1, 2, 1, 3, 4 };
            int k = 3;
            Solution sl = new Solution();
            int s = sl.SubarraysWithKDistinct(nums, k);
            //Console.Write("Maximum contiguous sum is " +                                    maxSubArraySum(a));
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



public class Solution
{

    public int SubarraysWithKDistinct(int[] nums, int k)
    {
        int sum = 0;
     
        for (int i = 0; i < nums.Length && nums.Length - i >= k; i++)
        {
            Hashtable ht = new Hashtable();
            if (k!=1)
            ht = RetrunHT(i, i + k - 2, nums);

            for (int j = i + k - 1; j < nums.Length ; j++)
            {
                if (j < nums.Length && !ht.ContainsKey(nums[j]))
                {
                    ht.Add(nums[j], 1);
                }
                if (ht.Count == k)
                {
                    sum++;
                   
                }
                else if (ht.Count >k )
                {
                    break;
                }
            }

        }
        return sum;
    }

    public Hashtable RetrunHT(int a, int b, int[] nums)
    {
        Hashtable ht = new Hashtable();

        for (int i = a; i <= b; i++)
        {
            if (!ht.ContainsKey(nums[i]))
            {
                ht.Add(nums[i], 1);
            }

        }
        return ht;
    }
}