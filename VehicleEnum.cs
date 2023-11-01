using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace VozidloEnum
{
    public enum TypeOfRoad
    {
        Obec = 1,
        MimoMesto = 2,
        Dalnice = 3
    }

    class Vehicle
    {
        public int Speed { get; set; }
        public TypeOfRoad TypeOfRoad { get; set; }

        public Vehicle(int speed, TypeOfRoad typeOfRoad)
        {
            Speed = speed;
            TypeOfRoad = typeOfRoad;
        }

        public void WriteInfo()
        {
            string className = this.GetType().Name;
            string roadType = GetRoadType(TypeOfRoad);

            Console.WriteLine($"Třída: {className}, Rychlost: {Speed}, Typ komunikace: {roadType}");

            if (TypeOfRoad == TypeOfRoad.Obec && Speed > 50)
            {
                Console.WriteLine("Pokuta: 1000 Kč");
            }
            else if (TypeOfRoad == TypeOfRoad.MimoMesto && Speed > 90)
            {
                Console.WriteLine("Pokuta: 1500 Kč");
            }
            else if (TypeOfRoad == TypeOfRoad.Dalnice && Speed > 130)
            {
                Console.WriteLine("Pokuta: 2000 Kč");
            }
        }

        protected string GetRoadType(TypeOfRoad roadCode)
        {
            switch (roadCode)
            {
                case TypeOfRoad.Obec:
                    return "v obci";
                case TypeOfRoad.MimoMesto:
                    return "mimo obec";
                case TypeOfRoad.Dalnice:
                    return "na dálnici";
                default:
                    return "neznámý typ komunikace";
            }
        }
    }

    class Car : Vehicle { public Car(int speed, TypeOfRoad typeOfRoad) : base(speed, typeOfRoad) { } }

    class Motorcycle : Vehicle { public Motorcycle(int speed, TypeOfRoad typeOfRoad) : base(speed, typeOfRoad) { } }

    class Tractor : Vehicle
    {
        public Tractor(int speed, TypeOfRoad typeOfRoad) : base(speed, typeOfRoad) { }

        public new void WriteInfo()
        {
            string className = this.GetType().Name;
            string roadType = GetRoadType(TypeOfRoad);

            Console.WriteLine($"Třída: {className}, Rychlost: {Speed}, Typ komunikace: {roadType}");

            if (Speed > 50 || TypeOfRoad == TypeOfRoad.Dalnice)
            {
                Console.WriteLine("Pokuta: 5000 Kč");
            }
        }
    }

    class TestVozidlo2
    {
        public static void Mainx(string[] args)
        {
            Vehicle vehicle1 = new Vehicle(60, TypeOfRoad.MimoMesto);
            Car car1 = new Car(70, TypeOfRoad.MimoMesto);
            Motorcycle bike1 = new Motorcycle(110, TypeOfRoad.Obec);
            Tractor tractor1 = new Tractor(40, TypeOfRoad.Obec);
            Tractor tractor2 = new Tractor(60, TypeOfRoad.Dalnice);

            vehicle1.WriteInfo();
            car1.WriteInfo();
            bike1.WriteInfo();
            tractor1.WriteInfo();
            tractor2.WriteInfo();
        }
    }
}

