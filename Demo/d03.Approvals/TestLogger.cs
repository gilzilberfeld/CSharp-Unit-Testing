using System.Text;

namespace UnitTestingCourse.Demo.d03.ApprovalsTesting
{
    public class TestLogger
    {

        private StringBuilder sb = new StringBuilder();

        public void Append(char key, String display)
        {
            sb.Append("Pressed " + key + ", Display shows: " + display + "\n");
        }

        public String GetAll()
        {
            return sb.ToString();
        }
    }
}
