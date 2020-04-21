using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class Taum_and_B_day
    {

        static void main(string[] args)
        {
         long result =   taumBday(27984, 1402, 619246, 615589, 247954);

            Console.WriteLine(result);

        }


        public static long taumBday(int b, int w, int bc, int wc, int z)
        {
            if (bc != wc)
            {
                if ((bc + z) < wc)
                {
                    return ((((long)b + w) * bc) + (long)(w * z));
                }
                else if ((wc + z) < bc)
                {
                    return ((((long)b + w) * wc) + ((long)b * z));
                }
                else
                {
                    return (((long)b * bc) + (long)((long)w * wc));
                }
            }
            else
            {
                return (((long)b * bc) + ((long)w * wc));
            }

        }
    }
}
