using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.PracticeProblem
{

    public class DutchNationalProblem
    {
        private int[] data = new int[] { 2, 1, 2, 0, 0, 1, 1, 2, 1, 0, 0, 0 };

        public void SolveDNP()
        {
            int start = 0;
            int middle = 0;
            int end = data.Length - 1;
            Console.WriteLine(string.Join(",", data));
            Console.WriteLine("Before starting");

            while (middle<=end)
            {
                int temp;
                switch (data[middle])
                {
                    case 0:
                        {
                            temp = data[start];
                            data[start] = data[middle];
                            data[middle] = temp;
                            middle++;
                            start++;
                        }
                        break;
                    case 1:
                        middle++;
                        break;
                    case 2:
                        {
                            temp = data[end];
                            data[end] = data[middle];
                            data[middle] = temp;
                            
                            end--;
                        }
                        break;
                }

                Console.WriteLine(string.Join(",",data));

            }
        }
    }
}
