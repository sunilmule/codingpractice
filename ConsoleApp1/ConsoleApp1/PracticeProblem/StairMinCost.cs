using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.PracticeProblem
{
    public class StairMinCost : IProblemFactory
    {
        private int[] cost = new int[] { 1, 100, 1, 1, 1, 100, 1, 1, 100, 1 };
        public void Solve()
        {
            Console.WriteLine("Cap :" + MinCostToStairClime(cost));
        }

        public int MinCostToStairClime(int[] cost)
        {

            var length = cost.Length;
            var minCost = new int[length + 1];

            minCost[0] = 0;
            minCost[1] = 0;
            for (int i = 2; i <= length; i++)
            {
                minCost[i] = Math.Min(cost[i - 1] + minCost[i - 1], cost[i - 2] + minCost[i - 2]);
            }

            return minCost[length];
        }
    }
}
