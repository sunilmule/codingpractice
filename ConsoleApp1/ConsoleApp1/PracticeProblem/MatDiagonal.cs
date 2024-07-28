using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

////
/////You have intercepted a secret message encoded as a string of numbers. The message is decoded via the following mapping:

//"1"-> 'A'

//"2"-> 'B'...

//"25"-> 'Y'

//"26"-> 'Z'

//However, while decoding the message, you realize that there are many different ways you can decode the message because some codes are contained in other codes ("2" and "5" vs "25").

//For example, "11106" can be decoded into:

//"AAJF" with the grouping (1, 1, 10, 6)
//"KJF" with the grouping (11, 10, 6)
//The grouping(1, 11, 06) is invalid because "06" is not a valid code(only "6" is valid).
//Note: there may be strings that are impossible to decode.

//Given a string s containing only digits, return the number of ways to decode it. If the entire string cannot be decoded in any valid way, return 0.

//The test cases are generated so that the answer fits in a 32-bit integer.
///
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
            for (int t = 0; t <= length; t++)
            {
                sum = sum + mat[i][j];
                if (k != j)
                    sum = sum + mat[k][i];
                i++;
                j++;
                k--;
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
