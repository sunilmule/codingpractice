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
                case "1" :
                    return new DutchNationalProblem();
                case "shipdays":
                case "2":
                    return new CapacityToShipPackages();
                case "ContainerWithMostWater":
                case "CMW":
                case "3":
                    return new ContainerWithMostWater();
                case "MatDiagonal":
                case "MDS":
                case "4":
                    return new MatDiagonal();
                case "Decode":                
                case "decode":                
                case "5":
                    return new Decode();

                case "StairClimb":
                case "stairclimb":
                case "6":
                    return new StairMinCost();
                default:
                    return new DefaultProblem();
            }
        }
    }
}
