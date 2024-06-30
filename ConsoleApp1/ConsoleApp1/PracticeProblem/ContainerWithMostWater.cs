using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.PracticeProblem
{
    public class ContainerWithMostWater : IProblemFactory
    {
        private int[] height = new int[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 };
        public void Solve()
        {
            Console.WriteLine("Cap :"+ MaxArea(height));
        }

        public int MaxArea(int[] height)
        {

            var left = 0;
            var right = height.Length - 1;
            var maxArea = 0;

            while (left < right)
            {
                var area = Math.Min(height[left], height[right]) * (right - left);

                maxArea = Math.Max(area, maxArea);

                if (height[left] < height[right])
                    left++;
                else
                    right--;

            }
            return maxArea;
        }
    }
}
