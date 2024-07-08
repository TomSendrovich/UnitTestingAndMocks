using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class FizzBuzzTests
    {
        [Test]
        public void GetOutput_NumberDividedByThreeAndFive_ReturnFizzBuzz()
        {
            var result = FizzBuzz.GetOutput(15);

            Assert.That(result, Is.EqualTo("FizzBuzz"));
        }

        [Test]
        public void GetOutput_NumberDividedByThreeOnly_ReturnFizz()
        {
            var result = FizzBuzz.GetOutput(3);

            Assert.That(result, Is.EqualTo("Fizz"));
        }

        [Test]
        public void GetOutput_NumberDividedByFiveOnly_ReturnBuzz()
        {
            var result = FizzBuzz.GetOutput(5);

            Assert.That(result, Is.EqualTo("Buzz"));
        }

        [Test]
        public void GetOutput_NumberNotDividedByThreeAndFive_ReturnNumberAsString()
        {
            var result = FizzBuzz.GetOutput(2);

            Assert.That(result, Is.EqualTo("2"));
        }

        [Test]
        public void GetOutput_NumberIsZero_ReturnReturnFizzBuzz()
        {
            var result = FizzBuzz.GetOutput(0);

            Assert.That(result, Is.EqualTo("FizzBuzz"));
        }


        [Test]
        public void GetOutput_NumberIsNegative_ReturnNumberAsString()
        {
            var result = FizzBuzz.GetOutput(-1);

            Assert.That(result, Is.EqualTo("-1"));
        }
    }
}
