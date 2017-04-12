using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabThree
{
    class Program
    {
        static void Main(string[] args)
        {
            bool run = true;
            int Num1;
            Double input = new Double();
            do
            {

                Console.WriteLine("Learn how to square and cube!");
                Console.WriteLine("Enter an Integer: ");
                Double.TryParse(Console.ReadLine(), out input);
                Console.WriteLine("Number\t" + "Squard\t" + "Cubed\t");


                Console.WriteLine("=====\t======\t=====");

                for (Num1 = 1; Num1 <= input; Num1++)
                {
                    Console.WriteLine(Num1 + "\t" + (Math.Pow(Num1, 2) + "\t" + (Math.Pow(Num1, 3))));
                }

                Console.WriteLine("Do you want to continue?");
                string sentence = Console.ReadLine();
                if (sentence.ToLower() == "no")
                    run = false;

            } while (run);

        }
    }
}
