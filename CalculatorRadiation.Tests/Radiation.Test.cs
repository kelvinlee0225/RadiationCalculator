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
            Assert.Throws<ArgumentException>(() => CalculateRadiation.Calc(-100, 100));
        }

        [Test]
        public void RadiationCalculator_Returns_ArgumentException_When_negative1_andsquareroot_is_Given()
        {
            Assert.Throws<ArgumentException>(() => CalculateRadiation.Calc(-1,2));
        }

        [Test]
        public void RadiationCalculator_Returns_ArgumentException_When_negative100_and4throot_is_Givenn()
        {
            Assert.Throws<ArgumentException>(() => CalculateRadiation.Calc(-100,4));
        }

        [Test]
        public void RadiationCalculator_Returns_ArgumentException_When_String_is_Given()
        {
            Assert.Throws<ArgumentException>(() => CalculateRadiation.Calc(-200,-46));
        }

        [Test]
        public void RadiationCalculator_Returns_5_When_25_and_Squareroot_is_Given()
        {
            Assert.AreEqual(5, CalculateRadiation.Calc(25,2));
        }

        [Test]
        public void RadiationCalculator_Returns_2_When_8and_CubeRoot_is__is_Given()
        {
            Assert.AreEqual(2, CalculateRadiation.Calc(8, 3));
        }

        [Test]
        public void RadiationCalculator_Returns_negative2_When_8and_CubeRoot_is__is_Given()
        {
            Assert.AreEqual(2, CalculateRadiation.Calc(8, 3));
        }

        [Test]
        public void RadiationCalculator_Returns_1dot73205080757_When_3_is_Given()
        {
            Assert.AreEqual(1.7320508075688772, CalculateRadiation.Calc(3, 2));
        }
    }
}