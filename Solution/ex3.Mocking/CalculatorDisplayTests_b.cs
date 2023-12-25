using Moq;
using UnitTestingCourse.Demo.d02.Mocking.Code;

namespace UnitTestingCourse.Solution.ex3.Mocking
{
    // 3. Use Moq
    public class CalculatorDisplayTests_b
    {

        [Test]
        public void When_display_is_off_display_not_connected()
        {
            var mockDisplay = new Mock<IExternalDisplay>();
            mockDisplay.Setup(display => display.IsOn()).Returns(false);

            CalculatorDisplay cd = new CalculatorDisplay(mockDisplay.Object);

            Assert.That(cd.IsDisplayConnected, Is.False);
        }

        [Test]
        public void When_display_is_on_display_is_correct()
        {
            var mockDisplay = new Mock<IExternalDisplay>();
            mockDisplay.Setup(display => display.IsOn()).Returns(true);
            CalculatorDisplay cd = new CalculatorDisplay(mockDisplay.Object);
            cd.Press("1");
            mockDisplay.Verify(display => display.Show("1"));
        }

        [Test]
        public void When_display_is_on_display_is_correct_with_captor()
        {
            List<string> args = new List<string>();
            
            var mockDisplay = new Mock<IExternalDisplay>();
            mockDisplay.Setup(display => display.IsOn()).Returns(true);
            mockDisplay.Setup(display => display.Show(Capture.In(args)));


            CalculatorDisplay cd = new CalculatorDisplay(mockDisplay.Object);
            cd.Press("1");
            Assert.That(args[0], Is.EqualTo("1"));
        }
    }
}
