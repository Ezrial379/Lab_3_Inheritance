using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_2_or_3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Car car = new Car("Car");

            Information car1 = new Information("Motorcycle", "Yamaha");

            Information_Full car2 = new Information_Full("HIMARIS", "Lockheed Martin", 2022);


            Buyer buyer = new Buyer();

            buyer.Buy(car);   // АБО МОЖНА СТВОРЮВАТИ НОВИЙ ОПИС МАШИНИ ПІД ЧАС ВИКЛИКУ МЕТОДУ КЛАСУ "Buyer"    buyer.Buy(new car(.....));

            buyer.Buy(car1);

            buyer.Buy(car2);



        }
    }


    class Buyer
    {

        public void Buy(Car car)
        {

            Console.WriteLine("\n \nDescription of the new buyed vehicle");


            car.Buy();

        }

    }


    class Car

    {
        public string Vehicle { get; set; }


        public Car(string vehicle)
        {



            Vehicle = vehicle;

        }

        public virtual void Buy()
        {



            Console.WriteLine("Type of vehicle: " + Vehicle);

        }

    }

    class Information : Car
    {

        public string Brand;

        public Information(string vehicle, string brand) : base(vehicle)
        {

            Brand = brand;

        }


        public override void Buy()
        {
            base.Buy();
            Console.WriteLine("Brand: " + Brand);
        }

    }

    class Information_Full : Car
    {
        public string Brand;
        public int Year;


        public Information_Full(string vehicle, string brand, int year) : base(vehicle)

        {

            Brand = brand;
            Year = year;

        }

        public override void Buy()
        {

            base.Buy();
            Console.WriteLine("Brand: " + Brand);
            Console.WriteLine("Year of manufacturing: " + Year);

        }

    }





}