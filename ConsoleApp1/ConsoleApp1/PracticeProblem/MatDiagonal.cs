using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.PracticeProblem
{
    public class MatDiagonal : IProblemFactory
    {
         int[][] mat = {
            new int[] { 1, 2, 3, 4 },
            new int[] { 5, 6, 7, 8 },
            new int[] { 1, 2, 3, 4 },
            new int[] { 5, 6, 7, 8 }
        };
        public int DiagonalSum(int[][] mat)
        {

            int length = mat[0].Length - 1;
            int i = 0;
            int j = 0;
            int k = mat[0].Length - 1;
            int sum = 0;
            // Console.WriteLine(length);
            for (int t = 0; t <= length; t++)
            {
                // Console.WriteLine("i:"+i+"j:"+j+": "+mat[i][j]);
                // Console.WriteLine("k:"+k+"i:"+i+": "+mat[k][i]);
                sum = sum + mat[i][j];
                if (k != j)
                    sum = sum + mat[k][i];
                i++;
                j++;
                k--;
                //Console.WriteLine("Sum :" +sum);
            }
            return sum;
        }

        public void Solve()
        {
          var result=  DiagonalSum(mat);

            Console.WriteLine("Matrix addition"+ result);
        }
    }


}
