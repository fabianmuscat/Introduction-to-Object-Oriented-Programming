using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Types_and_Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            // Syntax to create a variable: <data type> <variable> = <value>;

            // When creating a variable without assigning a value, this is called
            // a variable declaration.
            int num;

            // Here the variable initialisation is being done as there is an assignment statement,
            // meaning that a value is being assigned to the variable for the first time.
            num = 0;

            // Here both a variable declaration and initialisation are being done since the variable has been
            // both created and assigned a value.
            string name = "Jean";
            string surname = "Borg";
            int age = 26;
            double height = 400.35;
            
            // Concatenation: Joining two or more strings or a variable with the addition operator.
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Surname: " + surname);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Height: " + height);
            
            Console.WriteLine(); // new line
            
            // Console Reading Values: Instead of using concatenation, numbers are used as placeholders inside of
            // curly brackets which will be replaced by the variables value at runtime.
            Console.WriteLine("Full Name: {0} {1}", name, surname);
            Console.WriteLine("Age: {0}", age);
            Console.WriteLine("Height: {0}", height);
            
            Console.WriteLine();
            
            // String Interpolation: Similarly to the previous method, curly brackets are used to hold
            // the variables name which is then replaced by the value at runtime. In order for this to work
            // the $ needs to be added before the double quotes.
            Console.WriteLine($"Full Name: {name} {surname}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Height: {height}");
        }
    }
}
