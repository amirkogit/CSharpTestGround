using System;
using System.Collections;
using System.Collections.Generic;

namespace EqualityComparisons
{
    public class StructuralEqualityDemo
    {
        public static void RunDemo()
        {
            Console.WriteLine("StructuralEqualityDemo: Demonstrates structural equality and comparisons on an array");

            string[] arr1 = { "apple", "orange", "pineapple" };
            string[] arr2 = { "apple", "orange", "pineapple" };

            DisplayContents(arr1, "arr1: ");
            DisplayContents(arr2, "arr2: ");

            // reference equality
            Console.WriteLine("\nReference equality:");
            Console.WriteLine("arr1 == arr2: " + (arr1 == arr2));
            Console.WriteLine("arr1.Equals(arr2): " + arr1.Equals(arr2));

            // structural equality
            Console.WriteLine("\nStructural equality:");
            var arrayEq = (IStructuralEquatable)arr1; // must include: using System.Collections and not
                                                      // System.Collections.Generic
            bool structEqual = arrayEq.Equals(arr2, StringComparer.OrdinalIgnoreCase);

            Console.WriteLine(structEqual);

            // structural comparison
            Console.WriteLine("\nStructural comparison:");
            var arrayComp = (IStructuralComparable)arr1;
            int structCompResult = arrayComp.CompareTo(arr2, StringComparer.OrdinalIgnoreCase);
            Console.WriteLine(structCompResult);

            Console.WriteLine();
        }

        private static void DisplayContents(string[] list, string description)
        {
            Console.Write($"{description}: ");

            foreach(string item in list)
                Console.Write($"{item}\t");

            Console.WriteLine();
        }
    }
}
