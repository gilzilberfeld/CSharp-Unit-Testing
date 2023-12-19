using System.Collections;
using System.Collections.Generic;

namespace UnitTestingCourse.Demo.d01.NUnit
{
    internal class DataDrivenTests
    {
        Factorial factorial;
        [SetUp]
        public void SetUp()
        {
            factorial = new Factorial();
        }

        [Test]
        [TestCase(1, 1)]
        [TestCase(2, 2)]
        [TestCase(3, 6)]
        public void FactorialTests(int input, int expected)
        {
            Assert.That(factorial.Calculate(input), Is.EqualTo(expected));

        }

        [TestCaseSource(nameof(GetCases))]
        public void DataSourceTests(int input, int expected)
        {
            Assert.That(factorial.Calculate(input), Is.EqualTo(expected));
        }

        static IEnumerable GetCases()
        {
            yield return new object[] { 1, 1 };
            yield return new object[] { 2, 2 };
            yield return new object[] { 3, 6 };
        }
    }
}
