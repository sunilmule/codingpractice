using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.PracticeProblem
{
    public class CapacityToShipPackages : IProblemFactory
    {
        private int [] Weight = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        private int noOfDays = 5;
        public CapacityToShipPackages() { }

        public void Solve()
        {
           var result= CalculateCapacityToShipToPackages(Weight, noOfDays);
            Console.WriteLine("Data :+ "+result);
        }

        public int CalculateCapacityToShipToPackages(int[] weights, int D)
        {
            int minCap = weights.Max();
            int maxCap = weights.Sum();

            while (minCap < maxCap)
            {
                int mid = minCap + (maxCap - minCap) / 2;
                int sum = 0;
                int days = 1;
                foreach (var weight in weights)
                {
                    if (sum + weight > mid)
                    {
                        days++;
                        sum = 0;
                    }
                    sum += weight;
                }

                if (days > D)
                    minCap = mid + 1;
                else
                    maxCap = mid;
            }

            return minCap;
        }

        private int GetMin()
        {
            return Weight.Min();
        }

        private int GetMax()
        {
            return Weight.Sum();
        }
    }
}
