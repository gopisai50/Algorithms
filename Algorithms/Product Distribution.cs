using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class Product_Distribution
    {

        public static void main(string[] args)
        {
            List<List<int>> li = new List<List<int>>();
            li.Add(new List<int> { 0, 4 });


            maxScore(new List<int> { 1,5,4,2,3}, 2);
        }

        public static int maxScore(List<int> a, int m)
        {
            int k = m;
            int mul = 1;
            double maxscore = 0;
            double modulo = (Math.Pow(10, 9) + 7);
            if (a.Count <= m)
            {
                foreach (int i in a)
                {
                    maxscore += i;
                }
                return (int)(maxscore % modulo);
            }
            a.Sort();
            for (int i = 0; i < a.Count(); i++)
            {

                if (a.Count() - (i) > k)
                {
                    maxscore += (mul * a[i]);
                    m--;
                    if (m == 0)
                    {
                        m = k;
                        mul++;
                    }
                }
                else
                {
                    maxscore += (mul-1) * a[i];
                }
            }


            return (int)(maxscore % modulo);
        }

    }
}
