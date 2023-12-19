namespace UnitTestingCourse.Demo.d02.Mocking.Code
{
    public class Driver
    {

        private Car car;

        public Driver(Car car)
        {
            this.car = car;
        }

        public bool CanDrive()
        {
            return !car.IsRunning();
        }

        public void Drive()
        {
            car.SetAC(new AirCondition(ACMode.On));
            car.Start();
        }

    }
}
