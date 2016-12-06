using System;

namespace EqualityComparisions
{
    public class Inheritance
    {
        public static void RunDemo()
        {
            Console.WriteLine("Inheritance demo: Demonstrates that == doesn't work well with inheritance");

            WithString();
            WithObject();

            Console.WriteLine();
        }

        // Note: 'string' is implicitly derived from 'object'
        private static void WithObject()
        {
            Console.WriteLine("Case2: using object");

            object str1 = "apple";
            object str2 = string.Copy((string)str1);

            Console.WriteLine("Reference: " + ReferenceEquals(str1, str2)); // returns FALSE
            Console.WriteLine("Method: " + str1.Equals(str2)); // returns TRUE
            Console.WriteLine("Operator: " + (str1 == str2));   // returns FALSE: The operator == will give a wrong result
                                                                // because it is not virtual. Equals() method will work
            Console.WriteLine("Static: " + object.Equals(str1,str2)); // returns TRUE

            Console.WriteLine();
        }

        private static void WithString()
        {
            Console.WriteLine("Case1: using string");

            string str1 = "apple";
            string str2 = string.Copy(str1);

            Console.WriteLine("Reference: " + ReferenceEquals(str1, str2)); // returns FALSE : evaluates reference equality
            Console.WriteLine("Method: " + str1.Equals(str2)); // returns TRUE: evaluates value equality
            Console.WriteLine("Operator: " + (str1 == str2)); // returns TRUE : evaluates value equality
            Console.WriteLine("Static: " + object.Equals(str1, str2)); // returns TRUE : evaluates value equality

            Console.WriteLine();
        }
    }
}
