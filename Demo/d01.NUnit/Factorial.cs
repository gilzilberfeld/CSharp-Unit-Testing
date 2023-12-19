namespace UnitTestingCourse.Demo.d01.NUnit
{
    public class Factorial
    {
        public int Calculate(int number)
        {
            if (number <= 1)
                return number;
            else
                return Calculate(number - 1) * number;
        }
    }
}
