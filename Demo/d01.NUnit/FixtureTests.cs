namespace UnitTestingCourse.Demo.d01.NUnit
{
    internal class FixtureTests
    {
        Factorial factorial;
        [SetUp]
        public void SetUp()
        {
            factorial = new Factorial();
        }

        [Test]
        public void Factorial_Tests()
        {
            Assert.That(factorial.Calculate(1), Is.EqualTo(1));
            Assert.That(factorial.Calculate(2), Is.EqualTo(2));
            Assert.That(factorial.Calculate(3), Is.EqualTo(6));
        }

        [Test]
        [Ignore("Because it is not implemented")]

        public void Negative_Factorial()
        {
            Assert.That(factorial.Calculate(-3), Is.EqualTo(0));
        }

        [Test]
        public void Big_Factorial()
        {
            Assert.That(factorial.Calculate(10), Is.EqualTo(3628800));
        }

    }
}
