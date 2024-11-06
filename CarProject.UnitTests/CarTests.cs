using CarProject.Logic;

namespace CarProject.UnitTests
{
    [TestClass]
    public class CarTests
    {
        [TestMethod]
        public void ItShouldStandStill_GivenCreated()
        {
            //ARRANGE
            Car car = new Car();
            //ACT
            int actualSpeed = car.Speed;
            //ASSERT
            Assert.AreEqual(0, actualSpeed);
        }

        [TestMethod]
        public void ItShouldStore_GivenGearBetweenOneAndSix()
        {
            //ARRANGE
            Car car = new Car();
            //ACT
            car.Gear = 6;
            //ASSERT
            Assert.AreEqual(6, car.Gear);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Gear should be between 0 and 6")]
        public void ItShouldThrowAnExpection_GivenGearOutsideRange()
        {
            //ARRANGE
            Car car = new Car();
            //ACT
            car.Gear = 7;
            //ASSERT      
        }

        [TestMethod]
        public void ItShouldHaveASpeedOfZero_GivenNoAcceleration()
        {
            //ARRANGE
            Car car = new Car();
            //ACT
            car.Gear = 3;
            //ASSERT      
            Assert.IsTrue(car.Speed == 0);
        }
        [TestMethod]
        public void ItShouldHaveASpeedBetween30And180_GivenGear3AndAccelerated()
        {
            //ARRANGE
            Car car = new Car();
            //ACT
            car.Gear = 3;
            car.Accelerate();
            //ASSERT      
            Assert.IsTrue(car.Speed >= 30 && car.Speed <= 180);
        }
        class FakeDice : IDice
        {
            public int Dots { get { return 2; } }
            public bool RollWasCalled { get; private set; } = false;
            public void Roll()
            {
                RollWasCalled = true;
            }
        }
        [TestMethod]
        public void ItShouldHaveASpeedOf60_GivenGear3AndDiceShowsTwoDots()
        {
            //ARRANGE
            FakeDice fakeDice = new FakeDice();
            Car car = new Car(fakeDice);
            //ACT
            car.Gear = 3;
            car.Accelerate();
            //ASSERT      
            Assert.AreEqual(60, car.Speed);
        }
        [TestMethod]
        public void ItShouldCallDiceRoll_GivenAccelerateIsCalled()
        {
            //ARRANGE
            FakeDice fakeDice = new FakeDice();
            Car car = new Car(fakeDice);

            //ACT
            car.Accelerate();
            //ASSERT      
            Assert.IsTrue(fakeDice.RollWasCalled);
        }
    }
}
