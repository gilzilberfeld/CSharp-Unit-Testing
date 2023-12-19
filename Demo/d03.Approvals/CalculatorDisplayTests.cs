using ApprovalTests;
using ApprovalTests.Reporters;

namespace UnitTestingCourse.Demo.d03.ApprovalsTesting
{
    [UseReporter(typeof(VisualStudioReporter))]
    public class CalculatorDisplayTests
    {

        CalculatorDisplay cd;
        TestLogger log;

        [SetUp]
        public void setup()
        {
            cd = new CalculatorDisplay();
            log = new TestLogger();
        }

        [Test]
        public void CheckDisplayTest()
        {
            cd.Press("1");
            Approvals.Verify(cd.GetDisplay());
        }


        [Test]
        [Ignore("Until necessary")]
        public void ComplexOperationsTest()
        {
            PressSequence("1+2=");
            Approvals.Verify(log.GetAll());
        }

        private void PressSequence(string sequence)
        {
            foreach (char key in sequence)
            {
                Press(key);
            }
        }

        private void Press(char key)
        {
            cd.Press((key).ToString());
            log.Append(key, cd.GetDisplay());
        }

    }
}
