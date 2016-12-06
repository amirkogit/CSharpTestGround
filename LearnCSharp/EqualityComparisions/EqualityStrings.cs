using System;

namespace EqualityComparisons
{
    public class EqualityStrings
    {
        public static void RunDemo()
        {
            Console.WriteLine("Equality Strings demo: Demonstrates == and Equals() for string");

            string str1 = "String1";
            string str2 = string.Copy(str1);

            Console.WriteLine("Reference: " + ReferenceEquals(str1, str2)); // returns FALSE : evaluates reference equality
            Console.WriteLine("Operator: " + AreStringEqualOp(str1, str2));
            Console.WriteLine("Method: " + AreStringEqualMethod(str1, str2));

            Console.WriteLine();
        }

        static bool AreStringEqualOp(string x, string y)
        {
            return x == y; // returns TRUE : evaluates value equality
        }

        static bool AreStringEqualMethod(string x, string y)
        {
            return x.Equals(y); // returns TRUE : evaluates value equality --> string overrides == operator underthehood!
        }
    }
}
