using System;

namespace Pythagoras
{
    class Program
    {
        static void Main(string[] args)
        {

            // Opgave Pythagoras

            // Kode

            Console.WriteLine("Første nummer: ");

            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Anden nummer: ");

            double b = double.Parse(Console.ReadLine());

            double first = Math.Pow(a, 2);
            double second = Math.Pow(b, 2);


            // Udskriver result
            Console.WriteLine("\n");
            Console.WriteLine(first + second);
            Console.WriteLine("\n");

            // If Statements

            if (first > second)
            {
                Console.WriteLine("Første nummer er størst.");
            }
            else if (first == second)
            {
                Console.WriteLine("Begge ligeværdig!");
            }
            else
            {
                Console.WriteLine("Anden nummer er størst.");
            }


            // Prevents the program from closing.

            Console.ReadKey();
        }
    }
}
