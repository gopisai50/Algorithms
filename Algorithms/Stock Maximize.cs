using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class Stock_Maximize
    {

        public static void main(string[] args)
        {
            List<int> prices = new List<int>() {1,3,1,2};

           long res = stockmax(prices);
            Console.Write(res);
        }

        public static long stockmax(List<int> prices)
        {
            long profit = 0;
            for (int i = 0; i < prices.Count; i++)
            {

                int max = findmax(i, prices.Count - 1, prices);
                if (max != i)
                {
                    for (int j = i; j <= max - 1; j++)
                    {
                        profit += prices[max] - prices[j];

                    }
                    i = max ;
                }

            }

            return profit;

        }

        public static int findmax(int i, int l, List<int> prices)
        {
            int max = i;
            for (; i <= l; i++)
            {
             if(prices[max]<prices[i])
                {
                    max = i;
                }
            }
            return max;
        }
    }
}
