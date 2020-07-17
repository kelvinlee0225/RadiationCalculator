using System;

namespace RadiationCalculator
{
    public class CalculateRadiation
    {
        public static double Calc(double A, int N)
        {
            if(A < 1 && N %2 != 0)
            {
                throw new ArgumentException("Invalid Number");
            }
            return Math.Pow(A, 1.0 / N);
        }
    }
}
