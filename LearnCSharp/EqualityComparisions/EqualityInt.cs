using System;

namespace EqualityComparisions
{
    public class EqualityInt
    {
        public static void RunDemo()
        {
            Console.WriteLine("Equality int demo: Demonstrates == and Equals() for integers");

            Console.WriteLine("Operator: " + AreIntsEqualOp(3,3));
            Console.WriteLine("Method: " + AreIntsEqualMethod(3,3));

            Console.WriteLine();
        }

        static bool AreIntsEqualOp(int x, int y)
        {
            return x == y; // returns TRUE : evaluates value equality
        }

        static bool AreIntsEqualMethod(int x, int y)
        {
            return x.Equals(y); // returns TRUE : evaluates value equality
        }
    }
}
