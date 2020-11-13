using System;

namespace String_and_Enumeration
{
    enum Days
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }

    class Program
    {
        static void Main(string[] args)
        {
            string name1 = string.Empty;
            name1 = "Joe";
            string name2 = "Tommy";

            Console.WriteLine("First letter from Joe: " + name1[0]);
            Console.WriteLine("Last letter from Tommy: " + name2[name2.Length - 1]);
            Console.WriteLine("Name 1 equal to Name 2: " + (name1 == name2));
            Console.WriteLine("Name 1 not equal to Name 2: " + (name1 != name2));

            // String Methods and Properties

            // Length => This is a string property which returns the amount of characters a string contains.
            // Return Type: Integer

            // Contains() => Checks whether a string contains a substring.
            // Return Type: Boolean
            string str = "mmy";
            bool contains = name2.Contains(str);
            Console.WriteLine(contains);

            // IndexOf() => Returns the index of a given character or -1 if the character doesn't exist.
            // Return Type: Integer
            int index = name1.IndexOf('e');
            Console.WriteLine(index);

            // CompareTo() => Compares two strings.
            // Return Type: Integer
            int check = name1.CompareTo(name2);
            Console.WriteLine(check);

            // ToLower() => Changes a string to lowercase.
            // Return Type: string
            string lowerName1 = name1.ToLower();
            Console.WriteLine(lowerName1);

            // ToUpper() => Changes a string to uppercase.
            // Return Type: string
            string upperName1 = name1.ToUpper();
            Console.WriteLine(upperName1);

            // Remove() => Removes a given substring from a string. The start and index of these characters need to be provided.
            // Return Type: string
            string remove = name2.Remove(name2.IndexOf('o'), name2.IndexOf('y') - 1);
            Console.WriteLine(remove);

            // Substring() => Returns a new substring from a string. The start and index of these characters need to be provided.
            // Return Type: string
            string sub = name2.Substring(name2.IndexOf('o'), name2.IndexOf('y') - 1);
            Console.WriteLine(sub);

            // Trim() => Removes any leading and trailing whitespaces.
            // Return Type: 
            string word = "     Hello     ";
            string trim = word.Trim();
            Console.WriteLine(trim);

            int indexOfEnum = (int) Days.Tuesday;
            Console.WriteLine(indexOfEnum);
            Console.ReadKey();
        }
    }
}