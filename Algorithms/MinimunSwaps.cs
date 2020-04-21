using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class MinimunSwaps // to sort
    {
        
        static void main(string[] args)
        {

            int[] arr = new int[15] { 1,3,5,2,4,7,6,8,9,10,12,11,13,15,14};
            minimumSwaps(arr);

        }

        static int minimumSwaps(int[] arr)
        {
            int count = 0;
            Dictionary<int, int> dic = new Dictionary<int, int>();

            for(int i=0;i<arr.Length;i++)
            {
                if(arr[i]!=i+1)
                {
                    if(!dic.ContainsValue(arr[i]) )
                    {
                        dic.Add(arr[i],i + 1);
                    }
                    else
                    {
                      count +=   check(dic,arr,i,count);
                    }
                }
             

            }


            return count;

        }
        static int check(Dictionary<int,int> dic,int[]arr,int i,int count )
        {

            if (arr[i] == i + 1)
            {
                return 0;
            }
            if (!dic.ContainsValue(arr[i]))
            {
                return 0;
            }
            else { 
            int j = arr[i];
            int temp = 0;
            temp = arr[j-1];
            arr[j-1] = arr[i];
            arr[i] = temp;
              
                dic[arr[i]] = i+1;
               return 1+ check(dic, arr, i,count);
            }

        }

    }
    }
