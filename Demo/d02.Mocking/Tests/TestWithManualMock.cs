using UnitTestingCourse.Demo.d02.Mocking.Code;

namespace UnitTestingCourse.Demo.d02.Mocking.Tests
{

    public class MockRunningCar : Car
    {
        override public bool IsRunning()
        {
            return true;
        }
    }

    public class MockNotRunningCar : Car
    {
        override public bool IsRunning()
        {
            return false;
        }
    }

    public class TestWithManualMock
    {

        [Test]
        public void Cannot_drive_a_running_car()
        {
            Car mockCar = new MockRunningCar();
            Driver driver = new Driver(mockCar);

            Assert.That(driver.CanStartDriving(), Is.False);

        }

        [Test]
        public void Can_drive_a_not_running_car()
        {
            Car mockCar = new MockNotRunningCar();
            Driver driver = new Driver(mockCar);

            Assert.That(driver.CanStartDriving(), Is.True);

        }

    }

}
