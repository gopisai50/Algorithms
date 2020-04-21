using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class Encryption
    {

        static void main(string[] args)
        {

            string str = "chillout";
            stringEncryption(str);

        }

        static void stringEncryption(string s)
        {
            double sqrt = Math.Sqrt((double)s.Length);
            int column = (int)Math.Ceiling(sqrt);
            int row = (int)Math.Floor(sqrt);
            char[] chr = s.ToCharArray();
            if((row*column)<s.Length )
            {
                row = column;
            }
            string result=null;

            for(int i=0;i< column;i++ )
            {
                int j = 0;
                int temp = i;
                while (j<row)
                {
                    if(temp<s.Length)
                    {
                        result = result + chr[temp]; 
                    
                    temp = temp + column;
                    
                    }
                    j = j + 1;
                }
                result = result +" ";
            }
            Console.Write(result);
            Console.ReadKey();
        }
    }
}
