using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _01_Value_Types_Business_Problem
{
    enum Vehicle
    {
        NotAssigned,
        Car,
        Motorcycle,
        Boat,
        Airplane
    }

    class Program
    {

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Welcome to Komodo!");

                Console.WriteLine("What is your name?");
                var name = Console.ReadLine();

                Console.WriteLine($"Hello {name}, what is your age?");
                var age = Int32.Parse(Console.ReadLine());
                if (age < 18)
                {
                    Console.WriteLine("You're too young");
                    return;
                }

                Console.WriteLine("What type of vehicle are you wanting to ensure?");

                Console.WriteLine(" 1: Car \r\n 2: Motorcycle \r\n 3: Boat \r\n 4: Airplane");
                int tempInsuranceQuote = Int32.Parse(Console.ReadLine());
                Vehicle vehicle = Vehicle.NotAssigned;

                switch (tempInsuranceQuote)
                {
                    case 1:
                        vehicle = Vehicle.Car;
                        break;
                    case 2:
                        vehicle = Vehicle.Motorcycle;
                        break;
                    case 3:
                        vehicle = Vehicle.Boat;
                        break;
                    case 4:
                        vehicle = Vehicle.Airplane;
                        break;
                    default:
                        Console.WriteLine("Please select a vehicle from the options");
                        break;
                        
                }

                const int youngPriceCar = 150;
                const int youngPriceMotorcycle = 200;
                const int youngPriceBoat = 200;
                const int youngPriceAirplane = 1000;

                const int oldPriceCar = 50;
                const int oldPriceMotorcycle = 100;
                const int oldPriceBoat = 100;
                const int oldPriceAirplane = 500;

                const int olderPriceCar = 100;
                const int olderPriceMotorcycle = 250;
                const int olderPriceBoat = 150;
                const int olderPriceAirplane = 1000;


                if (age >= 18 && age <= 27)
                {
                    CreateInsuranceQuote(vehicle, youngPriceCar, youngPriceMotorcycle, youngPriceBoat,
                        youngPriceAirplane);
                }
                else if (age >= 28 && age <= 65)
                {
                    CreateInsuranceQuote(vehicle, oldPriceCar, oldPriceMotorcycle, oldPriceBoat,
                        oldPriceAirplane);
                }
                else if (age >= 66)
                {
                    CreateInsuranceQuote(vehicle, olderPriceCar, olderPriceMotorcycle, olderPriceBoat,
                        olderPriceAirplane);
                }

                

                Console.ReadLine();
            }

        }

        public static void CreateInsuranceQuote(Vehicle vehicle, int carPrice, int motorcyclePrice, int boatPrice, int airplanePrice)
        {
            switch (vehicle)
            {
                case Vehicle.Car:
                    Console.WriteLine($"Your insurance estimate is ${carPrice} per month");
                    break;
                case Vehicle.Motorcycle:
                    Console.WriteLine($"Your insurance estimate is ${motorcyclePrice} per month");
                    break;
                case Vehicle.Boat:
                    Console.WriteLine($"Your insurance estimate is ${boatPrice} per month");
                    break;
                case Vehicle.Airplane:
                    Console.WriteLine($"Your insurance estimate is ${airplanePrice} per month");
                    break;
            }
        }
    }
}
