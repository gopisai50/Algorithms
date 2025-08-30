using System;

namespace Algorithms
{

    //https://leetcode.com/problems/minimum-size-subarray-sum/description/
    public class MinimumSizeSubArraySum
    {

        public static void main(string[] args)
        {
            int[] nums = new int[] { 1, 1, 1, 1, 1, 1, 1, 1 };
            MinSubArrayLen(11, nums);
        }

        public static int MinSubArrayLen(int target, int[] nums)
        {

            int sum = 0;
            int minLenght = Int32.MaxValue;

            for (int i = 0, j = 0; j < nums.Length;)
            {

                sum = sum + nums[j];

                if (sum >= target)
                {
                    minLenght = Math.Min(minLenght, FindMin(i, j, nums, target, sum));
                    sum = sum - nums[i];
                    i++;
                }
                j++;

            }
            return minLenght == Int32.MaxValue ? 0 : minLenght;
        }

        public static int FindMin(int i, int j, int[] nums, int target, int sum)
        {
            if (sum >= target)
            {
                while (sum - nums[i] >= target)
                {
                    sum = sum - nums[i];
                    i++;
                }
            }
            return j - i + 1;
        }
    }
}
