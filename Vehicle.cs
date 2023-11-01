using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace VehicleAndRoad
{
    class Vehicle
    {
        public int Speed { get; set; }
        public int TypeOfRoad { get; set; }

        public Vehicle(int speed, int typeOfRoad)
        {
            Speed = speed;
            TypeOfRoad = typeOfRoad;
        }

        public void WriteInfo()
        {
            Console.WriteLine($"Rychlost: {Speed}, Typ komunikace: {TypeOfRoad}");

            if (TypeOfRoad == 1 && Speed > 50)
            {
                Console.WriteLine("Pokuta: 1000 Kč");
            }
            else if (TypeOfRoad == 2 && Speed > 90)
            {
                Console.WriteLine("Pokuta: 1500 Kč");
            }
            else if (TypeOfRoad == 3 && Speed > 130)
            {
                Console.WriteLine("Pokuta: 2000 Kč");
            }
        }
    }

    class Car : Vehicle { public Car(int speed, int typeOfRoad) : base(speed, typeOfRoad) { } }

    class Motorcycle : Vehicle { public Motorcycle(int speed, int typeOfRoad) : base(speed, typeOfRoad) { } }

    class Tractor : Vehicle
    {
        public Tractor(int speed, int typeOfRoad) : base(speed, typeOfRoad) { }

        public new void WriteInfo()
        {
            Console.WriteLine($"Rychlost: {Speed}, Typ komunikace: {TypeOfRoad}");

            if (Speed > 50 || TypeOfRoad == 3)
            {
                Console.WriteLine("Pokuta: 5000 Kč");
            }
        }
    }

    class TestVehicle
    {
        public static void Mainx(string[] args)
        {
            Vehicle vehicle1 = new Vehicle(60, 2);
            Car car1 = new Car(70, 2);
            Motorcycle bike1 = new Motorcycle(110, 1);
            Tractor tractor1 = new Tractor(40, 1);
            Tractor tractor2 = new Tractor(60, 3);

            vehicle1.WriteInfo();
            car1.WriteInfo();
            bike1.WriteInfo();
            tractor1.WriteInfo();
            tractor2.WriteInfo();
        }
    }
}

