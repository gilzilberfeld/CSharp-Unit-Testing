using UnitTestingCourse.Demo.d02.Mocking.Code;
using Moq;

namespace UnitTestingCourse.Demo.Tests
{


    public class TestWithMoqBehavior
    {

        [Test]
        public void A_running_car()
        {

            var mockCar = new Mock<Car>();
            mockCar.Setup(car => car.IsRunning()).Returns(true);


            Driver driver = new Driver(mockCar.Object);

            Assert.That(driver.CanDrive(), Is.False);
        }

        [Test]
        public void Mocking_with_recursive_mocks()
        {
            var mockCar = new Mock<Car> { DefaultValue = DefaultValue.Mock };
            Assert.That(mockCar.Object.GetAC(), Is.Not.Null);

            AirCondition ac = mockCar.Object.GetAC();
            var mockAC = Mock.Get(ac);
            mockAC.Setup(x => x.GetMode()).Returns(ACMode.On);

            Assert.That(ac.GetMode(), Is.EqualTo(ACMode.On));
        }
    }
}