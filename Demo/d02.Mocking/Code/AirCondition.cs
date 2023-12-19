namespace UnitTestingCourse.Demo.d02.Mocking.Code
{
    public class AirCondition
    {
        protected ACMode mode = ACMode.Off;
        public AirCondition() { }

        public AirCondition(ACMode mode)
        {
            this.mode = mode;
        }

        public virtual ACMode GetMode()
        {
            return mode;
        }
    }
    public enum ACMode
    {
        On,
        Off
    }
}
