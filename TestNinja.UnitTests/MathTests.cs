using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class MathTests
    {
        private Math _math;

        //SetUp - NUnit will call it before each test
        [SetUp]
        public void SetUp()
        {
            _math = new Math();
        }
        //TearDown - NUnit will call it after each test (mainly used in integration tests)

        [Test]
        [Ignore("Because I wanted to!")]
        public void Add_WhenCalled_ReturnTheSumOfArguments()
        {
            int result = _math.Add(1, 2);

            Assert.That(result, Is.EqualTo(3));
        }

        //Parameterized Test Method
        [Test]
        [TestCase(2, 1, 2)]
        [TestCase(1, 2, 2)]
        [TestCase(1, 1, 1)]
        public void Max_WhenCalled_ReturnTheGreaterArgument(int a, int b, int expectedResult)
        {
            int result = _math.Max(a, b);

            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        public void GetOddNumbers_LimitIsGreaterThanZero_ReturnOddNumbersUpToLimit()
        {
            var result = _math.GetOddNumbers(5);

            //Too General
            //Assert.That(result, Is.Not.Empty);

            //More Specific
            //Assert.That(result.Count(), Is.EqualTo(3));

            //Specific
            //Assert.That(result, Does.Contain(1));
            //Assert.That(result, Does.Contain(3));
            //Assert.That(result, Does.Contain(5));
            Assert.That(result, Is.EquivalentTo(new[] { 1, 3, 5 }));

            //make sure the order if it suppost to sort the list
            //Assert.That(result, Is.Ordered);

            //All items are unique
            //Assert.That(result, Is.Unique);
        }
    }
}
