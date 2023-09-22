namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.Make = "Jeep";
            myCar.Model = "Patriot Sport";
            myCar.Year = 2017;

            var myMotorcycle = new Car();
            myCar.Make = "Harley Davidson";
            myCar.Model = "Dyna FXDF";
            myCar.Year = 2009;

            var carList = new List<Car>() { myCar, myMotorcycle};

            Console.WriteLine(carList.Capacity);

            foreach (var vehicle in carList)
            {
                Console.WriteLine($"{vehicle.Make} {vehicle.Model} {vehicle.Year}");
            }
        }
    }
}
