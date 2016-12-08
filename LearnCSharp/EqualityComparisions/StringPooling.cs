using System;

namespace EqualityComparisons
{
    public class StringPooling
    {
        public static void RunDemo()
        {
            Console.WriteLine("StringPooling demo:");

            string apple1 = "Apple";
            string apple2 = "App" + "le";

            Console.WriteLine($"Strings are: {apple1} and {apple2}");

            Console.WriteLine("Result of apple1 == apple2: " + (apple1 == apple2));

            // this will return TRUE because apple1 and apple2 have been pooled into one instance
            Console.WriteLine("Result of ReferenceEquals(): " + ReferenceEquals(apple1,apple2));

            Console.WriteLine();
        }
    }
}
