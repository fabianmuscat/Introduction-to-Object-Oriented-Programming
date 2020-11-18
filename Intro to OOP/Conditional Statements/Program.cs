using System;

namespace Conditional_Statements
{
    class Program
    {
        static void Main(string[] args)
        {
            // if else, if, nested if else, switch, break, continue

            // == => compares the values of two or more variables
            // != => checks if two or more variables are NOT equal
            // > => greater than
            // < => less than
            // >= greater than or equal to
            // <= less than or equal to

            Console.Write("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age > 18)
                Console.WriteLine("You can drink");
            else
                Console.WriteLine("You cannot drink");

            Console.Write("Enter mark: ");
            int mark = Convert.ToInt32(Console.ReadLine());
            char grade = Char.MinValue;

            // && => shorthand AND operator
            // || => shorthand OR operator
            // ! => NOT operator
            if ((mark >= 0) && (mark <= 100))
            {
                if (mark >= 90)
                    grade = 'A';
                else if (mark >= 80)
                    grade = 'B';
                else if (mark >= 70)
                    grade = 'C';
                else if (mark >= 50)
                    grade = 'D';
                else 
                    grade = 'F';
            }

            Console.Write("Enter month number: ");
            int monthNum = Convert.ToInt32(Console.ReadLine());


            /* The switch statement is the same as
             * a nested if statement except case branching is used
             * instead of "if else". Each case contains an exact
             * possible value that can be placed inside the variable
             * which the switch is being performed on. A case is like
             * a condition.
             *
             * In a switch, logical and mathematical operators cannot be used but only
             * exact values.
             * The syntax for the switch statement is as follows:
             *
             * switch (<variable>) {
             *    case <condition>:
             *      <statement>;
             *      break;
             *
             *    default:
             *      <statement>
             *      break;
             *
             * default => this branch is only accessed if the value being compared
             * does not exist in any of the cases.
             */
            switch (monthNum)
            {
                case 1:
                    Console.WriteLine("January");
                    break;

                case 2:
                    Console.WriteLine("February");
                    break;

                case 3:
                    Console.WriteLine("March");
                    break;

                default:
                    Console.WriteLine("Invalid Month");
                    break;
            }

            Console.ReadKey();
        }
    }
}
