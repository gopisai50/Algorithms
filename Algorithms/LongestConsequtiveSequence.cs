using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{

    //https://leetcode.com/problems/longest-consecutive-sequence/description/
    internal class LongestConsequtiveSequence
    {
        public static void main(string[] args)
        {
            var result = LongestConsequtive(new int[] { 9, 1, 4, 7, 3, -1, 0, 5, 8, -1, 6 });

            Console.ReadKey();
        }


        //best solution O(n)
        public int longest(int[] nums)
        {
            if (nums.Length == 0)
                return 0;

            HashSet<int> numSet = new HashSet<int>(nums);
            int longestStreak = 0;

            foreach (int num in numSet)
            {
                // Only start counting if `num` is the start of a sequence
                if (!numSet.Contains(num - 1))
                {
                    int currentNum = num;
                    int currentStreak = 1;

                    while (numSet.Contains(currentNum + 1))
                    {
                        currentNum++;
                        currentStreak++;
                    }

                    longestStreak = Math.Max(longestStreak, currentStreak);
                }
            }

            return longestStreak;
        }

        //(O(n logn))
        public static int LongestConsequtive(int[] ar)
        {

            if (ar.Length == 0)
                return 0;

            Array.Sort(ar);

            int final = 0;

            int p = 1;
            for (int i = 0; i < ar.Length - 1; i++)
            {
                if (ar[i + 1] - ar[i] > 1)
                {
                    if (final < p)
                    {
                        final = p;
                    }
                    p = 0;

                }
                else if (ar[i + 1] - ar[i] == 1)
                {
                    p++;
                }
            }

            
            if (final < p)
            {
                final = p;
            }
            return final;
        }
    }
}
