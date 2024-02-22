using System;

namespace ComputeAverageApp
{
    internal class ComputeAverageProgram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 5 grades separated by new line:");
            double score1 = Convert.ToDouble(Console.ReadLine());
            double score2 = Convert.ToDouble(Console.ReadLine());
            double score3 = Convert.ToDouble(Console.ReadLine());
            double score4 = Convert.ToDouble(Console.ReadLine());
            double score5 = Convert.ToDouble(Console.ReadLine());
            double sum = score1 + score2 + score3 + score4 + score5;
            double totalAfterSum = sum / 5;
            double roundedAverage = Math.Round(totalAfterSum);
            
            Console.WriteLine("The average is " + totalAfterSum + " and round off to " + roundedAverage);
        }
    }
}