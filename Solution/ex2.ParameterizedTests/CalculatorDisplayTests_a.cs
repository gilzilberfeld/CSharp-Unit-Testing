using NUnit.Framework;
using System.Collections;
namespace UnitTestingCourse.Solution.ex2.ParameterizedTests
{
    //  1. Add parameterized tests
    public class CalculatorDisplayTests_a
    {

        private CalculatorDisplay cd;

        [SetUp]
        public void Setup()
        {
            cd = new CalculatorDisplay();
        }

        [Test]
        [TestCase("1", "1")]
        [TestCase("12", "12")]
        [TestCase("1+", "1")]
        public void CheckWithTestCase(String sequence, String expected)
        {
            PressSequence(sequence);
            ShouldDisplay(expected);
        }


        [TestCaseSource(nameof(GetCases))]
        public void CheckWithTestCaseSource(String sequence, String expected)
        {
            PressSequence(sequence);
            ShouldDisplay(expected);
        }

        static IEnumerable GetCases()
        {
            yield return new object[] { "1", "1" };
            yield return new object[] { "12", "12" };
            yield return new object[] { "1+", "1" };
        }

        private void ShouldDisplay(String expected)
        {
            Assert.That(cd.GetDisplay(), Is.EqualTo(expected));
        }

        private void PressSequence(String sequence)
        {
            foreach (char c in sequence)
                cd.Press(c.ToString());
        }


    }
}