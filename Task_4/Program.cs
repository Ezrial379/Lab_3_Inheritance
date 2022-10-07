using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Entering key = new Entering("pro");

            key.Entering_key();

            switch (key)
            {
                case 1:
                    Console.WriteLine("FFFF");
                    break;
            }


        }






        class ApplicationLicense
        {

            public void AllowTrial()
            {

                Console.WriteLine("Триальний режим");

            }

            public void AllowCommon()
            {

                Console.WriteLine("Безкоштовна версiя");

            }


            public void AllowPro()
            {

                Console.WriteLine("Платна версія");

            }


        }

        class Entering
        {

            public string Key { get; set; }

            public Entering(string key)
            {
                Key = key;
            }

            public void Entering_key()
            {

                Console.WriteLine("Введіть ключ: ");
                Key = Console.ReadLine();

            }


        }



    }
}
