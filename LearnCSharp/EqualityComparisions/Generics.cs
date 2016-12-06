using System;

namespace EqualityComparisions
{
    public class Generics
    {
        public static void RunDemo()
        {
            Console.WriteLine("Generics demo: Demonstrates that you need to use object.Equals() with generics");

            string str1 = "apple";
            string str2 = string.Copy(str1);
            DisplayWhetherArgsEqual(str1, str2);

            Console.WriteLine();
        }

        private static void DisplayWhetherArgsEqual<T>(T x, T y)
        {
            Console.WriteLine("Equal? " + object.Equals(x,y));

            // this line will not compile because we can't use == with generic types
            Console.WriteLine("(x == y) will not compile!!");
            //Console.WriteLine("Equal? " + (x == y));
        }
    }
}
