using System;

namespace Simple_Arithmetic
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program which stores two numbers and displays the
            // result of the subtraction of these two numbers.

            Console.Write("Insert your 1st random number: ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Insert a 2nd random number: ");
            int number2 = Convert.ToInt32(Console.ReadLine());

            int subtraction = number1 - number2;
            Console.WriteLine("number1 - number2 = " + subtraction);

            // Write a program to help a student convert a temperature in
            // Celsius to Fahrenheit using the following formula.
            // F = (9 * C / 5) + 32

            Console.Write("\nInsert the temperature in Celsius: ");
            double tempCel = Convert.ToDouble(Console.ReadLine());

            double tempFer = ((9 * tempCel) / 5) + 32;
            Console.Write("The temperature in Fahrenheit is: " + tempFer);

            Console.ReadKey();
        }
    }
}
