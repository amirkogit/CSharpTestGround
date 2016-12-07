using System;

namespace EqualityComparisons
{
    public class StringIntCompare
    {
        public static void RunDemo()
        {
            Console.WriteLine("StringIntCompare demo: Demonstrates using IEquatable<T> to compare strings and ints");

            string apple = "apple";
            string pear = "pear";

            // perform comparisons for string objects (string class implements IComparable<string>
            DisplayOrder(apple, pear);
            DisplayOrder(pear, apple);
            DisplayOrder(apple, apple);

            // perform comparisons for int(int or Int32 also implements IComparable<int>)
            DisplayOrder(3, 4);
            DisplayOrder(4, 3);
            DisplayOrder(3, 3);

            Console.WriteLine();
        }

        // helper function to display the result of comparisons
        static void DisplayOrder<T>(T x, T y) where T : IComparable<T>
        {
            int result = x.CompareTo(y);

            if(result == 0)
                Console.WriteLine("{0,12} = {1}", x, y);
            else if(result > 0)
                Console.WriteLine("{0,12} > {1}", x, y);
            else
                Console.WriteLine("{0,12} < {1}", x, y);
        }
    }
}
