using NUnit.Framework;

namespace UnitTestingCourse.Solution.ex1.WritingTests
{
    // 3. Refactor tests
    public class CalculatorDisplayTests_b
    {
        CalculatorDisplay cd;

        [SetUp]
        public void Setup()
        {
            cd = new CalculatorDisplay();
        }

        [Test]
        public void At_Start_Display_0()
        {
            ShouldDisplay("0");
        }

        [Test]
        public void Pressing_1_Displays_1()
        {
            cd.Press("1");
            ShouldDisplay("1");
        }

        [Test]
        public void pressing_12_displays_12()
        {
            PressSequence("12");
            ShouldDisplay("12");
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


