// See https://aka.ms/new-console-template for more information
using ConsoleApp1.PracticeProblem;


Console.WriteLine("Enter problem name");
var input =Console.ReadLine();
if (string.IsNullOrEmpty(input))
    input = "default";

IProblemFactory problemFactory = ProblemFactory.GetProblemFactory(input.Trim());

problemFactory.Solve();
 
Console.ReadLine();