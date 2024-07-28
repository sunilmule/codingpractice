using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.PracticeProblem
{
    public class Decode : IProblemFactory
    {
        int count = 0;
        public void Solve()
        {
            var res = NumDecodings("11");
            Console.WriteLine(res);
        }

        public int NumDecodings(string s)
        {
            int n = s.Length;
            char[] c = s.ToCharArray();
            int[] dp = new int[n + 1];
            dp[0] = 1;
            dp[1] = s[0] == '0' ? 0 : 1;

            for (int i = 2; i <= n; i++)
            {
                int oneDigit = Convert.ToInt32(s.Substring(i - 1, 1));
                int twoDigit = Convert.ToInt32(s.Substring(i - 2, 2));

                if (oneDigit >= 1)
                    dp[i] += dp[i - 1];

                if (twoDigit >= 10 && twoDigit <= 26)
                    dp[i] += dp[i - 2];
            }

            return dp[n];
        }

    }
}
