using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repeat
{
    class startClass
    {
        public static void Main(string[] args)
        {
            NumberFormatInfo number = new NumberFormatInfo()
            {
                NumberDecimalSeparator = ".",
            };
            /*
            Console.WriteLine("Tere tulemast!");
            string eesnimi = Console.ReadLine();
            Console.WriteLine($"Tere {eesnimi}");
            if (eesnimi.ToLower() == "zhora")
            {
                Console.WriteLine("Come to me!");
                Console.WriteLine("Lets go to the cinema.");
                Console.WriteLine("How old are you?: ");
                int year = Convert.ToInt32(Console.ReadLine());

                if(year < 6 || year >= 0)
                {
                    Console.WriteLine("Ticket will be free.");
                }
                else if (year >= 6 && year <= 14)
                {
                    Console.WriteLine("Ticket will be student ticket.");
                }
                else if (year >= 15 && year < 65)
                {
                    Console.WriteLine("Ticket will be full price.");
                }
                else if(year >= 65)
                {
                    Console.WriteLine("Ticket will be with discount.");
                }
                else
                {
                    Console.WriteLine("There is no tickets for zero year people.");
                }
            }
            else
            {
                Console.WriteLine("My milk ran away! You can't");
            }

            Console.Write("Enter the first number: ");
            double arv1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the second number: ");
            double arv2 = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine($"Answer: {arv1 * arv2}");
            */



            /*-----------------------------------------*/

            double milk = 1.32;
            double bun = 0.96;
            double bread = 1.12;

            Console.WriteLine("Do you wanna buy a milk? [yes / no]: ");
            string asMilk = Console.ReadLine();
            Console.WriteLine("Do you wanna buy a bread? [yes / no]: ");
            string asBread = Console.ReadLine();
            Console.WriteLine("Do you wanna buy a bun? [yes / no]: ");
            string asBun = Console.ReadLine();

            List<string> AuthorList = new List<string>();
            List<double> price2 = new List<double>();
            if (asMilk == "yes")
            {
                AuthorList.Add("milk");
                price2.Add(milk);
            }
            if (asBread == "yes")
            {
                AuthorList.Add("bread");
                price2.Add(bread);
            }
            if (asBun == "yes")
            {
                AuthorList.Add("bun");
                price2.Add(bun);
            }

            Console.Write("Products: ");
            Console.WriteLine(string.Join(", ", AuthorList));
            Console.Write("Price: ");
            Console.WriteLine(string.Join(", ",price2));

            Console.ReadLine();

        }
    }
}
