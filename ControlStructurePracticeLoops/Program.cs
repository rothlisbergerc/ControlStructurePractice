using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlStructurePracticeLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exercise 1:
            for (int i = 1; i <= 6; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();

            }
            Console.WriteLine();

            // Exercise 2:
            for (int i = 0; i <= 6; i++)
            {
                for (int j = i; j <= 6; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            // Exercise 3:
            for (int i = 1; i < 6; i++)
            {

                for (int j = 0; j <= i - 1; j++)
                {
                    Console.Write("\\");
                }


                for (int k = 1; k <= i * -2 + 10; k++)
                {
                    Console.Write(".");
                }


                for (int m = 0; m < i; m++)
                {
                    Console.Write("/");
                }
                Console.WriteLine();

            }

            Console.WriteLine();
            Console.WriteLine("----------------------------------");

            // Exercise 4 A:
            Console.WriteLine("Please enter an integer: ");
            string input = Console.ReadLine();
            int.TryParse(input, out int data);

            if (data < 10)
            {
                Console.WriteLine();
                Console.WriteLine("This number is too small.");
            }
            else if (data >= 10)
            {
                Console.WriteLine();
                Console.WriteLine("This number is big enough.");
            }

            Console.WriteLine();
            Console.WriteLine("----------------------------------");

            // Exercise 4 B:
            int total = 0;
            int submissions = 0;
            char sentinel = 'a';

            while (sentinel != 'q')
            {
                Console.WriteLine("Please enter an integer or enter 'q' to quit: ");
                string newInput = Console.ReadLine();
                int.TryParse(newInput, out int newData);

                if (newInput == "q")
                {
                    sentinel = 'q';
                    submissions -= 1;
                }

                total += newData;
                submissions += 1;
            }

            double average = Convert.ToDouble(total) / Convert.ToDouble(submissions);

            Console.WriteLine();
            Console.WriteLine($"Total: {total}");
            Console.WriteLine("Average: " + Math.Round(average, 2));
            Console.WriteLine();
            Console.WriteLine("----------------------------------");

            //Exercise 5:           
            string repeat = "";

            while (repeat != "d")
            {
                Console.WriteLine("Is privacy a right?");
                Console.WriteLine("A. Yes");
                Console.WriteLine("B. No");
                Console.WriteLine("C. Who is this?");
                Console.WriteLine("D. Exit");
                Console.WriteLine();
                Console.Write("Enter your choice: ");

                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "a":
                        Console.WriteLine("--------------------------------------");
                        Console.WriteLine("Google wants to know your location.");
                        Console.WriteLine("--------------------------------------");
                        Console.WriteLine();
                        break;
                    case "b":
                        Console.WriteLine("--------------------------------------");
                        Console.WriteLine("Enable your webcam and ");
                        Console.WriteLine("await further instructions.");
                        Console.WriteLine("--------------------------------------");
                        Console.WriteLine();
                        break;
                    case "c":
                        Console.WriteLine("--------------------------------------");
                        Console.WriteLine("CEASE YOUR INVESTIGATIONS");
                        Console.WriteLine("--------------------------------------");
                        Console.WriteLine();
                        break;
                    default:
                        repeat = Console.ReadLine();
                        break;
                }
            }

            Console.ReadKey();
        }
    }
}
