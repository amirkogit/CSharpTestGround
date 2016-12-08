using System;
using System.Collections.Generic;

namespace EqualityComparisons
{
    public class FoodItemNameOnlyEqualityComparerDemo
    {
        public static void RunDemo()
        {
            Console.WriteLine("FoodItemNameOnlyEqualityComparerDemo:");

            FoodItemValueType beetroot = new FoodItemValueType("beetroot", FoodGroup.Vegetables);
            FoodItemValueType pickledBeetroot = new FoodItemValueType("beetroot", FoodGroup.Sweets);

            var eqComparer = FoodItemNameOnlyEqualityComparer.Instance;
            bool result = eqComparer.Equals(beetroot, pickledBeetroot);

            Console.WriteLine("Equals? " + result.ToString());
            Console.WriteLine(eqComparer.GetHashCode(beetroot));
            Console.WriteLine(eqComparer.GetHashCode(pickledBeetroot));

            Console.WriteLine();
        }
    }
}
