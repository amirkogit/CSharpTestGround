using System;

namespace EqualityComparisons
{
    public class EqualStrings
    {
        public static void RunDemo()
        {
            Console.WriteLine("Equal strings demo:");

            string str1 = "First String";
            string str2 = string.Copy(str1);

            Console.WriteLine("str1 == " + str1);
            Console.WriteLine("str2 == " + str2);
            Console.WriteLine(str1 == str2); // returns TRUE : checks value equality

            Console.WriteLine();
        }
    }
}
