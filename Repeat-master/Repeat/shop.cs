using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repeat
{
    class shop
    {
        public static void Main(string[] args)
        {
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
                AuthorList.Add(asMilk);
                price2.Add(milk);
            }
            else if (asBread == "yes")
            {
                AuthorList.Add(asBread);
                price2.Add(bread);
            }
            else if (asBun == "yes")
            {
                AuthorList.Add(asBun);
                price2.Add(bun);
            }

            Console.WriteLine(AuthorList);
            Console.WriteLine(price2);

            Console.ReadLine();
        }
    }
}
