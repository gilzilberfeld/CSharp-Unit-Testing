using System;
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

    public class TestWithManualMock
    {

        [Test]
        public void Cannot_drive_a_running_car()
        {
            Car mockCar = new MockRunningCar();
            Driver driver = new Driver(mockCar);

            Assert.That(driver.CanDrive(), Is.False);

        }

    }

}
