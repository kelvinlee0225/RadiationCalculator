using System;

namespace RadiationCalculator
{
    public class CalculateRadiation
    {
        public static double Calc(double A, double N)
        {
            if((A < 1 && N %2 == 0))
            {
                throw new ArgumentException("Invalid number or nth root number");
            }
            return Math.Pow(A, 1.0 / N);
        }
    }
}

