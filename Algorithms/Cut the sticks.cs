using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class Cut_the_sticks
    {
        static void main(string[] args)
        {
            int[] a = new int[6] { 5, 4, 4, 2, 2, 8 };
            int[] result = cutTheSticks(a);
            Console.WriteLine(result);

        }

        static int[] cutTheSticks(int[] arr)
        {

            int[] result = new int[arr.Length];
            int f = 0;
            result[f] = arr.Length;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if(arr[i]>0)
                { 
                int count = 0;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] > 0)
                    {
                        if (arr[i] > arr[j])
                        {
                            int temp = arr[i];
                            arr[i] = arr[j];
                            arr[j] = temp;


                        }
                    }

                }
                    int least = arr[i];
                    for (int k = i; k < arr.Length; k++)
                {
                       
                   
                    arr[k] = arr[k] - least;
                    if (arr[k] == 0)
                    {
                        count += 1;
                    }
                }
                if ((result[f] - count) > 0)
                {
                    f++;
                    result[f] = result[f-1] - count;
                }
            }
            }
            List<int> list =result.ToList<int>();
            list.RemoveAll(a => a.Equals((int)0));
            return list.ToArray();

        }
    }
}
