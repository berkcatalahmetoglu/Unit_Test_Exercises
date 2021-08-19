using System;
using TestNinja.Fundamentals;
using NUnit.Framework;

namespace TestNinja.UnitTests
{
    [TestFixture]
    class DemeritPointsCalculatorTests
    {
        [Test]
        [TestCase(-1)]
        [TestCase(-10)]
        [TestCase(301)]
        public void CalculateDemeritPoints_SpeedIsOutOfRange_ThrowArgumentOutOfRangeException(int speed)
        {
            var testSpeed = new DemeritPointsCalculator();

            Assert.That(() => testSpeed.CalculateDemeritPoints(speed), Throws.Exception.TypeOf<ArgumentOutOfRangeException>());
        }

        [Test]
        [TestCase(0, 0)]
        [TestCase(50, 0)]
        [TestCase(65, 0)]
        [TestCase(75, 2)]
        [TestCase(85, 4)]
        [TestCase(90, 5)]
        [TestCase(100, 7)]
        public void CalculateDemeritPoints_WhenCalled_ReturnDemeritPoints(int speed, int expectedResult)
        {
            var testSpeed = new DemeritPointsCalculator();

            var result = testSpeed.CalculateDemeritPoints(speed);

            Assert.That(result, Is.EqualTo(expectedResult));
        }

    }
}
