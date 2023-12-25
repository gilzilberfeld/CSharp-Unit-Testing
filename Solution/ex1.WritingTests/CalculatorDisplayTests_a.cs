namespace UnitTestingCourse.Solution.ex1.WritingTests
{
    // 1. Write tests
    // 2. Incremental coding
    public class CalculatorDisplayTests_a
    {

        [Test]
        public void At_Start_Display_0()
        {
            CalculatorDisplay cd = new CalculatorDisplay();
            Assert.That(cd.GetDisplay(), Is.EqualTo("0"));
        }

        [Test]
        public void Pressing_1_Displays_1()
        {
            CalculatorDisplay cd = new CalculatorDisplay();
            cd.Press("1");
            Assert.That(cd.GetDisplay(), Is.EqualTo("1"));
            
        }

        [Test]
        public void pressing_12_displays_12()
        {
            CalculatorDisplay cd = new CalculatorDisplay();
            cd.Press("1");
            cd.Press("2");
            Assert.That(cd.GetDisplay(), Is.EqualTo("12")); 
        }
    }

}
