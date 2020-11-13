using System;

namespace Expressions_and_Type_Conversions
{
    class Program
    {
        static void Main(string[] args)
        {
            /* When asking the user to input a non-string value, that value must be converted
             * by using its corresponding method. The following are the methods needed to convert
             * different data types:
             *
             * string => No need for conversion
             *
             * short => ToUInt16
             * int => ToUInt32
             * long => ToUInt64
             *
             * ushort => ToUInt16
             * uint => ToUInt32
             * ulong => ToUInt64
             *
             * double => ToDouble
             * float => ToSingle
             * byte => ToByte
             * char => Conversion is not needed but the index of the first letter needs to be specified [0].
             */

            // 

            Console.Write("Enter your name: ");
            string nameInput = Console.ReadLine();
            
            Console.WriteLine($"Your name is {nameInput}");
            
            Console.Write("Enter your age: ");
            int ageInput = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Enter your height: ");
            double heightInput = Convert.ToDouble(Console.ReadLine());

            Console.Write("Insert your Name: ");
            string name = Console.ReadLine();

            Console.Write("Insert your Surname: ");
            string surname = Console.ReadLine();

            Console.Write("Insert you Age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Insert a negative number: ");
            short number = Convert.ToInt16(Console.ReadLine());

            Console.Write("Insert a random letter of the alphabet: ");
            char letter = Console.ReadLine()[0];

            Console.Write("Insert the result of the exam: ");
            byte result = Convert.ToByte(Console.ReadLine());

            Console.Write("What is the world's population?: ");
            long population = Convert.ToInt64(Console.ReadLine());

            Console.Write("Insert your salary in the space provided: ");
            float salary = Convert.ToSingle(Console.ReadLine());

            Console.Write("Insert your E-Mail address in the space provided: ");
            string email = Console.ReadLine();

            Console.Write("Insert your address in the space provided: ");
            string address = Console.ReadLine();

            Console.WriteLine("Insert the price of the car you purchased:  ");
            ushort carPrice = Convert.ToUInt16(Console.ReadLine());
        }
    }
}
