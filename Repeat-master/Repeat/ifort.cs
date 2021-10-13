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
            /*--------------------------------------
            Random rand = new Random();
            int a = rand.Next(1, 10);

            int r = 0;
            int quet = 0;
            Console.WriteLine(a);
            while(r != 5 && quet != a) {
                Console.Write("Write the number: ");
                quet = Convert.ToInt32(Console.ReadLine());
                r++;
               
            }
            
            if (quet == a) {
                Console.WriteLine("You won!");
            }
            else {
                Console.WriteLine("You lose!");
            }
            */
            /*--------------------------------------------------
            double[] mas = new double[4];
            for (int i = 0; i < 4; i++)
            {
                Console.Write("Write the number: ");
                double gusj = Convert.ToDouble(Console.ReadLine());
                mas[i] = gusj;
            }
            */

            int[] numbers = new int[4];

            Console.WriteLine("Enter the number.");
            for (int i = 0; i < numbers.Length; i++)
            {
                do
                {
                    Console.Write($"Enter {i + 1} the value of a four-digit number: ");
                } while (!int.TryParse(Console.ReadLine(), out numbers[i]));
            }

            Array.Sort(numbers);
            Array.Reverse(numbers);
            Console.Write("\nAnswer: ");
            foreach (int item in numbers)
                Console.Write(item);

            Console.ReadLine();


            Console.WriteLine();
            int ridadearv = 10, veergudearv = 10;
            if(args.Length == 2)
            {
                ridadearv = int.Parse(args[0]);
                veergudearv = int.Parse(args[1]);
            }
            for (int i = 1; i < ridadearv; i++)
            {
                for (int veerg = 1; veerg <= veergudearv; veerg++)
                {
                    Console.Write("{0, 5}", i * veerg);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }      
    }
}