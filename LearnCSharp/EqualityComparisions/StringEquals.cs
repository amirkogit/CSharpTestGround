using System;

namespace EqualityComparisions
{
    public class StringEquals
    {
        public static void RunDemo()
        {
            Console.WriteLine("String equals demo:");

            string banana = "banana";
            string banana2 = string.Copy(banana);

            Console.WriteLine($"banana: {banana}");
            Console.WriteLine($"banana2: {banana2}");

            bool refEquals = ReferenceEquals(banana, banana2); // returns FALSE : evaluates reference equality
            Console.WriteLine($"Reference equals: {refEquals}");

            bool normalEquals = banana.Equals((object)banana2); // returns TRUE: overrides equals() to do field by field equality test
            Console.WriteLine($"Normal equals: {normalEquals}"); 

            Console.WriteLine();
        }
    }
}
