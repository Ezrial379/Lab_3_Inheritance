using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    internal class License
    {
        static void Main(string[] args)
        {

            string Key;
            Console.WriteLine($"Введiть ключ доступу (можете вiдмовитись, натиснувши символ 'N') :");
            Key = Console.ReadLine();
            Console.WriteLine($"Ваш ключ: '{Key}'\n");

            switch (Key)
            {

                case "pro":
                    {
                        Console.WriteLine($"Вас вiтає версiя Pro\n");
                        ApplicationLicense proWorker = new ApplicationLicense();
                        proWorker.AllowPro();

                        break;
                    }


                case "trial":
                    {
                        Console.WriteLine($"Вас вiтає версiя Trial\n");
                        ApplicationLicense trialWorker = new ApplicationLicense();
                        trialWorker.AllowTrial(); 

                        break;
                    }


                case "N":
                    {
                        Console.WriteLine($"Вас вiтає безкоштовна версія\n");
                        ApplicationLicense freeWorker = new ApplicationLicense();
                        freeWorker.AllowCommon();

                        break;
                    }


                default:

                    Console.WriteLine("Невiрна дiя. Такого коду немає.");

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


    }



}
