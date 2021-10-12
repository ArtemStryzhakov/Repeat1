using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repeat
{
    class ifort
    {
        public static void Main(string[] args)
        {
            /*
            int mult = 1;
            int sum = 0;

            for (int i = 0; i < 5; i++)
            {
                int smt = Convert.ToInt32(Console.ReadLine());
                sum += smt;
                mult = smt + mult;
            }
            double avg = sum / 5;
            Console.WriteLine($"Nums AVG = {avg}\nNums SUM = {sum}\nNums multiplied = {mult}");
               

            string text;
            do
            {
                Console.WriteLine("Buy the elephant!");
                Console.Write("Buy: ");

                text = Console.ReadLine();

            } while (text != "elephant");

            Console.WriteLine("You bought the elephant");

            */

            Random rand = new Random();
            int a = rand.Next(1, 10);

            int r = 0;
            int quet;
            do
            {
                Console.Write("White the number: ");
                quet = Convert.ToInt32(Console.ReadLine());
                r++;
                if(r == 5)
                {
                    break;
                }
            } while (quet != a);

            Console.WriteLine("You won!");
        }

       
    }
}
