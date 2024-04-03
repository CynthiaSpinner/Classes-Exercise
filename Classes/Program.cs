namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.Make = "Chevy";
            myCar.Model = "Blazer";
            myCar.Year = 1998;

            var toyota = new Car("Toyota", "Camry", 2001);

            var rover = new Car()
            {
                Make = "Land Rover",
                Model = "Ranger Rover Sport HSE",
                Year = 2013
            };

            

            var carList = new List<Car>() { myCar, toyota, rover};

            
            foreach (var vehicle in carList) 
            {
                Console.WriteLine($"{vehicle.Make} {vehicle.Model} {vehicle.Year}");
            }
        }
    }
}
