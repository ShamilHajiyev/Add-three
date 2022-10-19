using System;

namespace Overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nConverted number:\n" + Convert3(input));
        }
        public static int Convert3(int input)
        {
            int number = input;
            int counter = 0;
            while (number != 0)
            {
                number /= 10;
                counter++;
            }

            int coeff = 1;
            for (int i = 0; i < counter; i++)
            {
                coeff *= 10;
            }
            int newNumber = input + 3 * coeff;
            return newNumber;
        }
    }
}
