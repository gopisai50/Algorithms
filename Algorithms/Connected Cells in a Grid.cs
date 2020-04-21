using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class Connected_Cells_in_a_Grid
    {

        public static void main(string[] args)
        {
            int[][] a = new int[4][];
            a[0] = new int[4] { 1, 1, 0, 0 };
            a[1] = new int[4] { 0, 1, 1, 0 };
            a[2] = new int[4] { 0, 0, 1, 0 };
            a[3] = new int[4] { 1, 0, 0, 0 };

            connectedCell(a, 4, 4);



        }
        static int connectedCell(int[][] matrix, int rows, int columns)
        {
            int result = 0;

            for (int i = 0; i < matrix.Length;i++)
            {
                for(int j=0;j<matrix[i].Length;j++)
                {
                    if(matrix[i][j]==1)
                    { 
                    int sum = findLargestArea(matrix,i,j);
                    result = Math.Max(result, sum);
                    }
                }

            }
            return result;
            Console.Write(result);



    }
        static int findLargestArea(int [][]arr,int row ,int col)
        {
            
            if(row<0||col<0||row>=arr.Length ||col>=arr[row].Length || arr[row][col] == 0)
            {
                return 0;
            }
            arr[row][col] = 0;
            int sum = 1;
            for(int i =row-1;i<=row+1;i++)
            {
                for(int j=col-1;j<=col+1;j++)
                {
                 
                    {
                    sum=sum+  findLargestArea(arr, i, j);
                    }
                }
            }
            return sum;
          
        }
    }
}
