using Moq;
using UnitTestingCourse.Demo.d02.Mocking.Code;

namespace UnitTestingCourse.Demo.d02.Mocking.Tests
{
    internal class TestWithMoqVerification
    {
        [Test]
        public void AC_is_set_before_we_drive()
        {
            var mockCar = new Mock<Car>();
            Driver driver = new Driver(mockCar.Object);
            driver.Drive();
            mockCar.Verify(car => car.SetAC(It.IsAny<AirCondition>()),
                Times.Once);
        }


        [Test]
        public void AC_is_set_before_we_drive_2()
        {
            var mockCar = new Mock<Car>();
            Driver driver = new Driver(mockCar.Object);

            ACMode sentACMode = ACMode.On;
            mockCar.Setup(car => car.SetAC(It.IsAny<AirCondition>()))
                .Callback((AirCondition ac) => sentACMode = ac.GetMode());

            driver.Drive();
            Assert.That(sentACMode, Is.EqualTo(ACMode.On));
        }

        [Test]
        public void AC_is_set_before_we_drive_3()
        {
            var mockCar = new Mock<Car>();
            Driver driver = new Driver(mockCar.Object);

            var airConditions = new List<AirCondition>();
            mockCar.Setup(car => car.SetAC(Capture.In(airConditions)));

            driver.Drive();
            Assert.That(airConditions[0].GetMode(), Is.EqualTo(ACMode.On));
        }
    }
}