namespace UnitTestingCourse.Solution.ex3.Mocking
{
    // 2. mock manually external display
    public class CalculatorDisplayTests_a
    {

        [Test]
        public void When_external_display_is_off_display_not_connected()
        {
            MockDisplay display = new MockDisplay();
            display.isOn = false;
            CalculatorDisplay cd = new CalculatorDisplay(display);

            Assert.That(cd.IsDisplayConnected, Is.False);
        }

        [Test]
        public void When_display_is_on_display_is_correct()
        {
            MockDisplay display = new MockDisplay();
            display.isOn = true;
            CalculatorDisplay cd = new CalculatorDisplay(display);
            cd.Press("1");
            Assert.That(display.GetText(), Is.EqualTo("1"));
        }

    }
}
