using System;

namespace EqualityComparisons
{
    public class EqualInts
    {
        public static void RunDemo()
        {
            Console.WriteLine("Equal int demo:");

            int three = 3;
            int threeAgain = 3;
            bool intCmp = (three == threeAgain); // returns TRUE : checks value equality
            Console.WriteLine($"Compare ints: {intCmp}"); 

            bool objCmp = ((object)three == (object)threeAgain); // returns FALSE : checks reference equality
            Console.WriteLine($"Compare objects: {objCmp}");

            bool iComparableCmp = 
                ((IComparable<int>)three == (IComparable<int>)threeAgain); // returns FALSE : checks reference equality
            Console.WriteLine($"Compare interfaces: {iComparableCmp}");

            Console.WriteLine();
        }
    }
}
