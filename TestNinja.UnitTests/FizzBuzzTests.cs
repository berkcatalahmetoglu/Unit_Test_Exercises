using NUnit.Framework;
using System;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    class FizzBuzzTests
    {
        [Test]
        public void GetOutput_InputDivisibleBy3and5_ReturnFizzBuzz()
        {
            var result = FizzBuzz.GetOutput(15);

            Assert.That(result, Is.EqualTo("FizzBuzz"));
        }

        [Test]
        public void GetOutput_InputDivisibleBy3Only_ReturnFizz()
        {
            var result = FizzBuzz.GetOutput(9);

            Assert.That(result, Is.EqualTo("Fizz"));
        }

        [Test]
        public void GetOutput_InputDivisibleByOnly5_ReturnBuzz()
        {
            var result = FizzBuzz.GetOutput(10);

            Assert.That(result, Is.EqualTo("Buzz"));
        }

        [Test]
        public void GetOutput_InputIsNotDivisibleBy3Or5_ReturnTheSameNumber()
        {
            var result = FizzBuzz.GetOutput(1);

            Assert.That(result, Is.EqualTo("1"));
        }
    }
}
