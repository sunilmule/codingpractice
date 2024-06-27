using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.PracticeProblem
{
    public static class ProblemFactory
    {
        

        public static IProblemFactory GetProblemFactory(string type)
        {
            switch (type.ToLower()) 
            {
                case "dnp":
                case "dutchnationalflagproblem" :
                    return new DutchNationalProblem();
                default:
                    return new DefaultProblem();
            }
        }
    }
}
