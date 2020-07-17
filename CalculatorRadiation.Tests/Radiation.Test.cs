using NUnit.Framework;
using RadiationCalculator;
using System;

namespace CalculatorRadiation.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void RadiationCalculator_Returns_ArgumentException_When_No_Argument_is_Given()
        {
            Assert.Throws<ArgumentException>(() => CalculateRadiation.Calc());
        }
        public void RadiationCalculator_Returns_ArgumentException_When_No_Argument_is_Given()
        {
            Assert.Throws<ArgumentException>(() => CalculateRadiation.Calc());
        }
        public void RadiationCalculator_Returns_ArgumentException_When_No_Argument_is_Given()
        {
            Assert.Throws<ArgumentException>(() => CalculateRadiation.Calc());
        }
        public void RadiationCalculator_Returns_ArgumentException_When_No_Argument_is_Given()
        {
            Assert.Throws<ArgumentException>(() => CalculateRadiation.Calc());
        }

        [Test]
        public void RadiationCalculator_Returns_5_When_25_and_Squareroot_is_Given()
        {
            Assert.AreEqual(5, CalculateRadiation.Calc(25,2));
        }

        [Test]
        public void RadiationCalculator_Returns_2_When_8and_CubeRoot_is__is_Given()
        {
            Assert.AreEqual(5, CalculateRadiation.Calc(25, 3));
        }

        [Test]
        public void RadiationCalculator_Returns_9_When_81_is_Given()
        {
            Assert.AreEqual(9, CalculateRadiation.Calc(81, 2));
        }

        [Test]
        public void RadiationCalculator_Returns_1dot73205080757_When_3_is_Given()
        {
            Assert.AreEqual(1.73205080757, CalculateRadiation.Calc(3, 2));
        }
    }
}