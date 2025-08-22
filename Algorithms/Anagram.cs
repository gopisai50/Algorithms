using System;
using System.Linq;

namespace Algorithms
{
    class Anagram
    {

        public static void Main(string[] args)
        {
           Console.Write(reverse("I am Gopi"));

            // ipog ma I
            // gopi am I
            Console.ReadKey();
        }


        static string reverse(string s)
        {
           var arrchar = s.Reverse();
            var arrchar1 = arrchar.ToArray();
            int firstpont = 0;
            for (int i =0; i < arrchar1.Length; i++ )
            {
                if (arrchar1[i] == ' ')
                {
                    reverse(arrchar1, firstpont, i);
                    firstpont = i - 1;
                }
            }

           return  new String(arrchar1);

        }

        static void reverse(char[] arr, int start, int end)
        {
            int j = end;
            for (int i = start; i < end; i++)
            {



            }


        }

    }


       

        //static int anagram(string s)
        //{

        //    if (s.Length % 2 != 0)
        //    {
        //        return -1;
        //    }
        //    else
        //    {
        //        int count = 0;
        //        int middle = s.Length / 2;
        //        var a1 = s.Substring(0, middle).ToCharArray();
        //        var a2 = s.Substring(middle, middle);

        //        for (int i = 0; i < a1.Length; i++)
        //        {
        //            if (a2.IndexOf(a1[i]) == -1)
        //            {
        //                count++;
        //            }
        //            else
        //            {

        //                a2 = a2.Substring(0, a2.IndexOf(a1[i])) + a2.Substring(a2.IndexOf(a1[i])+1);
        //            }
        //        }
        //        return count;
        //    }


        //}

    }
