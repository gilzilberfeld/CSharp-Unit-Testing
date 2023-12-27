namespace UnitTestingCourse.Solution.ex3.Mocking
{
    public class MockDisplay : IExternalDisplay
    {
        public bool isOn;
        private string text="";

        public void Show(string text)
        {
            this.text = text;
        }

      
        public bool IsOn()
        {
            return isOn;
        }

        public string GetText()
        {
            return this.text;
        }

    }

}
