namespace UnitTestingCourse.ex3.Mocking
{
    public class PlasmaScreen
    {
        public static void Show(string text)
        {
            throw new ApplicationException("Not Connected");
        }
    }
}
