using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class Maximal_Char_Requests
    {

        public static void main(string[] args)
        { List<List<int>> li = new List<List<int>>();
            li.Add(new List<int> { 0,4});

            
            getMaxCharCount("ddaaa", li);
        }

        public static List<int> getMaxCharCount(string s, List<List<int>> queries)
        {
            // queries is a n x 2 array where queries[i][0] and queries[i][1] represents x[i] and y[i] for the ith query.
            List<int> res = new List<int>();
            char[] cr = s.ToCharArray();
            for (int i = 0; i < queries.Count; i++)
            {
                int max = 0;
                int count = 0;
                int start = queries[i][0];
                int end = queries[i][1];

                for (int j = start; j <= end; j++)
                {
                    if (cr[j] >= 97)
                    {
                        cr[j] = (char)((int)cr[j] - 32);
                    }
                    if (max < (int)cr[j])
                    {
                        max = (int)cr[j];
                        count = 0;
                    }
                    if (max == (int)cr[j])
                    {
                        count++;
                    }

                }
                res.Add(count);
            }
            return res;
        }
    }
}
