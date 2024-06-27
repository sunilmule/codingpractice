using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.PracticeProblem
{

    public class DutchNationalProblem : IProblemFactory
    {
        private int[] data = new int[] { 2, 1, 2, 0, 0, 1, 1, 2, 1, 0, 0, 0 };

        public void Solve()
        {
            SolveDNP();
        }

        private void SolveDNP()
        {
            int start = 0;
            int middle = 0;
            int end = data.Length - 1;
            Console.Write("Input Array : ");
            Console.WriteLine(string.Join(",", data));


            while (middle <= end)
            {
                switch (data[middle])
                {
                    case 0:
                        {
                            Swap(start, middle);
                            middle++;
                            start++;
                        }
                        break;
                    case 1:
                        middle++;
                        break;
                    case 2:
                        {
                            Swap(middle, end);
                            end--;
                        }
                        break;
                }

                Console.WriteLine(string.Join(",", data));

            }

            Console.Write($"Final O/p Array : {string.Join(",", data)}");
        }

        private void Swap(int index1, int index2)
        {
            int temp = data[index1];
            data[index1] = data[index2];
            data[index2] = temp;
        }
    }
}
