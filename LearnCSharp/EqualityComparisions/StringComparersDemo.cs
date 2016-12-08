using System;
using System.Collections.Generic;

namespace EqualityComparisons
{
    public class StringComparersDemo
    {
        public static void RunDemo()
        {
            Console.WriteLine("StringComparers demo: Demonstrates built in StringComparer to sort items in a collection");

            //var names = new HashSet<string>(); // will insert both 'apple' and 'Apple'
            var names = new HashSet<string>(StringComparer.CurrentCultureIgnoreCase); // will insert only 'apple': ignores case!

            names.Add("apple");
            names.Add("pear");
            names.Add("pineapple");
            names.Add("Apple");

            foreach(string name in names)
                Console.WriteLine(name);

            Console.WriteLine();
        }
    }
}
