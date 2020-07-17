using System;
using RadiationCalculator;

namespace CalculatorRadiationConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Nth root:");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("\nThe answer is: ");
            Console.WriteLine(CalculateRadiation.Calc(a, n));
        }
    }
}
