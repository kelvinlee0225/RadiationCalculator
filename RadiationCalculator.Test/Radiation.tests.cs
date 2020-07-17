using NUnit.Framework;
using CalculatorRadiation;
using System;

namespace RadiationCalculator.Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            Radiation radiation = new Radiation();
        }

        [Test]
        // public void CalculateRadiation_Return_ArgumentsException_When_No_Argument_is_Given()
        // {
        //     Assert.Throws<ArgumentException>(() => CalculatorRadiation.Calc());
        // }
        // public void CalculateRadiation_Return_ArgumentsException_When_A_is_Given()
        // {
        //     Assert.Throws<ArgumentException>(() => CalculatorRadiation.Calc());
        // }

        // public void CalculateRadiation_Return_ArgumentsException_When_Negative5_is_Given()
        // {
        //     Assert.Throws<ArgumentException>(() => CalculatorRadiation.Calc());
        // }

        // public void CalculateRadiation_Return_ArgumentsException_When_A_Negative_ZeroPoint5_is_Given()
        // {
        //     Assert.Throws<ArgumentException>(() => CalculatorRadiation.Calc());
        // }

        public void CalculateRadiation_Return_5_When_25_is_Given()
        {
            Radiation radiation = new Radiation();
            Assert.AreEqual(5, radiation.Calc(25));
        }
        // public void CalculateRadiation_Return_ArgumentsException_When_A_Negative_ZeroPoint5_is_Given()
        // {
        //     Assert.Throws<ArgumentException>(() => CalculatorRadiation.Calc());
        // }
        // public void CalculateRadiation_Return_ArgumentsException_When_A_Negative_ZeroPoint5_is_Given()
        // {
        //     Assert.Throws<ArgumentException>(() => CalculatorRadiation.Calc());
        // }
        // public void CalculateRadiation_Return_ArgumentsException_When_A_Negative_ZeroPoint5_is_Given()
        // {
        //     Assert.Throws<ArgumentException>(() => CalculatorRadiation.Calc());
        // }

    }
}