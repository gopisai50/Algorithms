using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public  class LongestOnes
    {

        public static void Main(string[] args)
        {
            int[] nums = new int[] { 0, 0, 0, 1 };
            LongestOnesFunction(nums, 4);
        }


        public static int LongestOnesFunction(int[] nums, int k)
        {

            int maxValue = Int32.MinValue;
            int tempMax = 0;

            int tempk = k;

            for (int j = 0, i = 0; j < nums.Length; j++)
            {
                if(nums[j] == 1)
                {
                    tempMax++;
                }
                else if (nums[j] == 0 && tempk > 0)
                {
                    tempk--;
                    tempMax++;
                }
                else
                {
                    maxValue = Math.Max(maxValue, tempMax);
                    tempMax = 0;
                    tempk = k;
                    i++;
                    j = i - 1;
                }
            }

            maxValue = Math.Max(maxValue, tempMax);

            return maxValue;


        }


    }



}
