namespace CarDealershipWithUnitTesting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CarDealer dealer = new("Bob's Cars", "304 Car Street");
            Car volvo = new Car("Volvo", "AB12345", 2020, 400);
            Car honda = new Car("Honda", "AC12345", 1970, 30000);

            dealer.AddCar(volvo);
            dealer.AddCar(honda);

            string highKmCars = dealer.ShowCars(dealer.GetHighKmCars(300));
            Console.WriteLine(highKmCars); 

            string oldCars = dealer.ShowCars(dealer.GetOldCars(2000));
            Console.WriteLine(oldCars); 

        }
    }
}