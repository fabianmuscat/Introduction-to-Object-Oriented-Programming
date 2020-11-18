using System;

namespace Repetition_Control_Statements
{
    class Program
    {
        static void Main(string[] args)
        {
            // ++ => increment (adds one to the current value)
            // -- => decrement (subtracts one from the current value)

            // for loop
            /* This is a predetermined loop which means that the number of times
             * that the code inside the loop is going to be executed is known prior
             * to the execution of the code.
             * The syntax for a for loop is as follows:
             *
             * for (int i = 0; i < x; i++) {
             *      <statement>
             * }
             *
             * int i = 0; => initialisation
             * i < x; => loop condition where x is the number of times the loop will be executed
             * i++ => iterator (i will be incremented by 1 until the loop condition becomes true)
             */

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(i);
            }
            /* Output:
             * 0
             * 1
             * 2
             * 3
             */

            // while loop
            /* The while loop is not a predetermined loop which means that the amount of
             * times the loop will be executed is unknown. The loop will break only if the
             * condition becomes true. This loop will be executed 0 or more times depending on the
             * loop condition.
             * The syntax for a while loop is as follows:
             *
             * while (<condition>) {
             *      <statement>
             *      <statement>
             * }
             */
            int counter = 10;
            while (counter > 0)
            {
                Console.WriteLine("The counter is: " + counter);
                counter--;
            }
            /* Output:
             * The counter is: 10
             * The counter is: 9
             * The counter is: 8
             * The counter is: 7
             * The counter is: 6
             * The counter is: 5
             * The counter is: 4
             * The counter is: 3
             * The counter is: 2
             * The counter is: 1
             */

            Console.WriteLine();

            //do... while loop
            /* The do while loop is the same as the while loop except that this loop
             * must be executed at least once.
             * The syntax for the do while loop is as follows:
             *
             * do {
             *    <statement>
             *    <statement>
             * } while (<condition>);
             */

            counter = 10;
            do
            {
                Console.WriteLine("The counter is: " + counter);
                counter--;
            } while (counter > 0);
            /* Output:
             * The counter is: 10
             * The counter is: 9
             * The counter is: 8
             * The counter is: 7
             * The counter is: 6
             * The counter is: 5
             * The counter is: 4
             * The counter is: 3
             * The counter is: 2
             * The counter is: 1
             */

            // break statement
            /* The break statement is used to terminate or break a loop.
             * This is normally inside of a condition. If a condition is met,
             * the loop is terminated.
             */
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
                if (i == 5)
                    break;
            }
            /* Output:
             * 0
             * 1
             * 2
             * 3
             * 4
             * 5
             */

            Console.WriteLine();

            // continue statement
            /* The continue statement breaks or skips a specific iteration in
             * a loop if a given condition is met, and continues with the next iteration.
             */
            for (int i = 0; i < 20; i++)
            {
                if (i > 5 && i < 15)
                    continue;
                Console.WriteLine(i);
            }
            /* Output:
             * 0
             * 1
             * 2
             * 3
             * 4
             * 5
             * 15
             * 16
             * 17
             * 18
             * 19
             */

            Console.ReadKey();
        }
    }
}
