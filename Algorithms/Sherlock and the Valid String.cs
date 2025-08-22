using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class Sherlock_and_the_Valid_String
    {


        public static void main(string[] args)
        {
            isValid("aabbcd");
        }

        static string isValid(string s)
        {

            char[] cr = s.ToCharArray();
            Hashtable ht = new Hashtable();
            for (int i = 0; i < cr.Length; i++)
            {
                if (ht.ContainsKey(cr[i]))
                {
                    ht[cr[i]] = (int)ht[cr[i]] + 1;
                }
                else
                {
                    ht.Add(cr[i], 1);
                }
            }
            int j = 0;
            int[] arr = new int[ht.Count];
            int count = 0;
            bool flag = true;
            #region pointers
            //foreach (DictionaryEntry kp in ht)
            //{
            //    if (j == 0)
            //    {
            //        arr[j] = (int)kp.Value;
            //        j++;
            //    }
            //    else
            //    {
            //        if ((arr[min] == (int)kp.Value))
            //        {
            //            min++;
            //            arr[j] = (int)kp.Value;
            //        }
            //        else
            //        {

            //            mes += Math.Abs(arr[min] - (int)kp.Value);
            //            if (min == 0)
            //            {
            //                min++;
            //            }
            //            arr[j] = (int)kp.Value;

            //        }
            //        j++;

            //    }


            //}

            #endregion


            foreach (DictionaryEntry kp in ht)
            {
                arr[j] = (int)kp.Value;
                check(arr, j);//insertion sort
                j++;
            }

            int min = 0; int max = arr.Length - 1;
            int cmn = 0; bool flag1 = true;

            for(int k=0;k<=arr.Length /2;k++)
            {
                if (arr[min] == arr[max])
                {
                    return "Yes";
                }
                else if (arr[min] == arr[min + 1])
                {

                    cmn = arr[min];
                    if (Math.Abs(arr[min] - arr[max]) > 1)
                    {
                        if (arr[min] == 1 || arr[max] == 1)
                        {
                            flag1 = false;
                        }
                        else
                            return "NO";

                    }
                    else if (Math.Abs(arr[min] - arr[max]) == 1)
                    {
                        if (flag)
                            flag1 = false;
                        else
                            return "NO";
                    }
                }
                else if (arr[min + 1] == arr[max])
                {
                    cmn = arr[max];
                    if (Math.Abs(arr[min] - arr[min - 1]) > 1)
                    {
                        if (flag == true)
                        {
                            if (arr[min - 1] == 1 || arr[min] == 1)
                            {
                                flag1 = false;
                            }

                            else
                                return "NO";
                        }
                        else return "NO";
                    }
                    else if (Math.Abs(arr[min] - arr[max]) == 1)
                    {
                        if (flag)
                            flag1 = false;
                        else
                            return "NO";
                    }


                }
                else
                    return "NO";
            }

            //bubble sort
            for(int i=0;i<arr.Length;i++)
            {
                for(int k=i+1;k<arr.Length;k++)
                {
                    if(arr[i]>arr[k])
                    {
                        int temp = arr[i];
                        arr[i] = arr[k];
                        arr[k] = temp;
                    }
                    
                }
                if (i != 0)
                {
                    if(arr[i - 1] != arr[i])
                    {
                        if(arr[i-1]==1)
                        {
                            count++;
                        }
                        else
                        {
                            count = Math.Abs(arr[i - 1] - arr[i]);
                        }
                    }
                }
                if(count>1)
                {
                    flag = false;
                    break;
                }
            }
            if (flag)
            {
                return "YES";
            }
            else
            {
                return "NO";
            }


        }

        public static void check(int [] arr,int i)
        {
            if(i<=0)
            {
                return;
            }
            if(arr[i-1]<arr[i])
            {
                return;
            }
            int temp = arr[i];
            arr[i] = arr[i - 1];
            arr[i - 1] = temp;
            check(arr, i - 1);
        }
    }


}
