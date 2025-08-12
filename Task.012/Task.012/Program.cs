using Task._012.Vehicles;

namespace Task._012
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Car car = new Car
           {
               FactoryName = "Lada",
               Model = "Vaz 2107",
               Color = "Black",
               DriveTime = 2,
               DrivePath = 280,
               DoorCount = 4,
               IsElectricCar = false
           };
            Car car2 = new Car
            {
                FactoryName = "BMW",
                Model = "X7",
                Color = "White",
                DriveTime = 1.5,
                DrivePath = 280,
                DoorCount = 4,
                IsElectricCar = false
            };
            Car car3 = new Car
            {
                FactoryName = "Tesla",
                Model = "Model S",
                Color = "Black",
                DriveTime = 2.5,
                DrivePath = 350,
                DoorCount = 4,
                IsElectricCar = true
            };
            Bicycle bicycle = new Bicycle
            {
                FactoryName = "Giant",
                Model = "Escape 3",
                Color = "Blue",
                DriveTime = 1.5,
                DrivePath = 30,
                Type = "Road"
            };

            Vehicle[] vehisles = {car, car2,car3, bicycle};

            foreach (var vehicle in vehisles)
            {
                vehicle.PrintInfo();
            }
            Console.WriteLine("--------------------------------");
            car.DefineNatureHarmness();
            car2.DefineNatureHarmness();
            car3.DefineNatureHarmness();
            bicycle.DefineNatureHarmness();
            Console.WriteLine("-----------------------------------");
            car.PrintInfo();
            Console.WriteLine("------------------------------------");
            bicycle.PrintInfo();

        }
    }
}
