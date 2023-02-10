using CarDealershipWithUnitTesting;

namespace CarDealership.test
{
    public class Tests
    {
        [Test]
        public void TestAddCar()
        {
            // Arrange
            var dealer = new CarDealer("name", "address");
            var car = new Car("car", "123", 2000, 20);
            var car2 = new Car("car", "123", 2000, 20);

            // Act
            dealer.AddCar(car);
            dealer.AddCar(car2);

            // Assert

            Assert.That(car, Is.EqualTo(dealer.Cars[0]));
            Assert.That(car2, Is.EqualTo(dealer.Cars[1]));
        }

        [Test]
        public void TestRemoveCar()
        {
            var dealer = new CarDealer("name", "address");
            var car = new Car("car", "1234", 2000, 20);
            var car2 = new Car("car", "1235", 2000, 20);
            dealer.AddCar(car);
            dealer.AddCar(car2);

            dealer.RemoveCar("1234");

            Assert.That(car2, Is.EqualTo(dealer.Cars[0]));
        }

        [Test]
        public void TestOldCars()
        {
            var dealer = new CarDealer("name", "address");
            var car = new Car("car", "123", 2000, 20);
            var car2 = new Car("car", "123", 2020, 20);
            dealer.AddCar(car);
            dealer.AddCar(car2);

            var oldCars = dealer.GetOldCars(2010);

            Assert.That(oldCars[0], Is.EqualTo(car));
        }

        [Test]
        public void TestHighKmCars()
        {
            var dealer = new CarDealer("name", "address");
            var car = new Car("car", "123", 2000, 20);
            var car2 = new Car("car", "123", 2000, 2000);
            dealer.AddCar(car);
            dealer.AddCar(car2);

            var highKmCars = dealer.GetHighKmCars(100);

            Assert.That(highKmCars[0], Is.EqualTo(car2));
        }
    }
}