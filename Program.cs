using System;

namespace RadiationCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Nth root:");
            int n = int.Parse(Console.ReadLine());

            CalculateRadiation.Calc(a, n);
        }
    }
}
