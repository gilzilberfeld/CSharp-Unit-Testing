namespace UnitTestingCourse.Demo.d01.NUnit
{
    public class FactorialTests
    {
        [Test]
        public void Factorial_Tests()
        {
            Factorial factorial = new Factorial();
            Assert.That(factorial.Calculate(1), Is.EqualTo(1));
            Assert.That(factorial.Calculate(2), Is.EqualTo(2));
            Assert.That(factorial.Calculate(3), Is.EqualTo(6));
        }

        [Test]
        [Ignore("Because it is not implemented")]

        public void Negative_Factorial()
        {
            Factorial factorial = new Factorial();
            Assert.That(factorial.Calculate(-3), Is.EqualTo(0));
        }

        [Test]
        public void Big_Factorial()
        {
            Factorial factorial = new Factorial();
            Assert.That(factorial.Calculate(10), Is.EqualTo(3628800));
        }
    }
}