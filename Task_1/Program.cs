using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3_inheritance
{



    class Methods
    {


        static void Main(string[] args)
        {
            Person person = new Person("Bob", "Dec", 18);
            person.Print(); // Bob Dec 18


            Information employee = new Information("Tom", "Oct", 15, "Kyiv");
            employee.PrintInf();   // Tom Oct 15 Kyiv різними кольорами


        }

    }

    class Person

    {

        public string Name { get; set; }
        public string Birth_Month { get; set; }
        public int Birth_Date { get; set; }

        public Person(string name, string birth_month, int birth_date)
        {

            Name = name;
            Birth_Month = birth_month;
            Birth_Date = birth_date;

        }


        public void Print()
        {

            Console.WriteLine("Name: " + Name + ", Birth date: " + Birth_Date + ", Birth month: " + Birth_Month);

        }

    }


    class Information : Person
    {

        public string City { get; set; }
        public Information(string name, string birth_month, int birth_date, string city)

            : base(name, birth_month, birth_date)

        {

            Console.WriteLine("\nПовна iнформацiя про людину:\n");
            City = city;

        }

        public void PrintInf()
        {

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Name: " + Name);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Birth month: " + Birth_Month);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Birth date: " + Birth_Date);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("City: " + City);
            Console.ForegroundColor = ConsoleColor.White;

        }

    }



}
