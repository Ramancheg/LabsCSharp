using Lab2.MyClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Garage testGarage = new Garage();
            testGarage.Vehicles.Add(new Bicycle { Brand = "Focus", MaxSpeed = 70, Price = 12500, YearOfRelease = 2017, Type = "Шоссер" });
            testGarage.Vehicles.Add(new Car { Brand = "Renault Kangoo", MaxSpeed = 220, Price = 150000, YearOfRelease = 2005, OpenRoof = false });
            testGarage.Vehicles.Add(new Lorry { Brand = "ЗИЛ", MaxSpeed = 170, Price = 310000, YearOfRelease = 1990, CountOfWheels = 6 });

            Garage garage = (Garage)testGarage.DeepCopy();
            Console.WriteLine(garage.ToString());

            Console.WriteLine("(Garage == TestGarage) : {0}", garage == testGarage);
            Console.WriteLine("(Garage != TestGarage) : {0}", garage != testGarage);

            Console.WriteLine("(Bicycle equels Bicycle) : {0}", garage.Vehicles[0].Equals(garage.Vehicles[0]));
            Console.WriteLine("(Bicycle equels Car) : {0}", garage.Vehicles[0].Equals(garage.Vehicles[1]));
            Console.WriteLine("(Bicycle equels Lorry) : {0}", garage.Vehicles[0].Equals(garage.Vehicles[2]));

            Console.WriteLine("(Car equels Car) : {0}", garage.Vehicles[1].Equals(garage.Vehicles[1]));
            Console.WriteLine("(Car equels Lorry) : {0}", garage.Vehicles[1].Equals(garage.Vehicles[2]));

            try
            {
                for(int i = 0; i < 10; i++)
                {
                    if(i > garage.Vehicles.Count - 1)
                    {
                        throw new Exceptions.IndexOutOfRangeException("");
                    }
                    Console.WriteLine(garage.Vehicles[i].ToString());
                }
            }
            catch (Exceptions.IndexOutOfRangeException)
            {
                Console.WriteLine("Oops..."); 
            }

            Console.ReadKey();
        }
    }
}
