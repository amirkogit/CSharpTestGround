using System;
using System.Collections.Generic;

namespace EqualityComparisons
{
    public class InconsistentSortingDemo
    {
        public static void RunDemo()
        {
            Console.WriteLine("InconsistentSorting Demo: Demonstrates how sort order can be inconsistent " + 
                              "if you don't check all fields when comparing!");

            // List1: contains some items of base and derived class
            FoodBaseRefType[] foodList1 =
            {
                new FoodBaseRefType("apple", FoodGroup.Fruit),
                new FoodBaseRefType("pear", FoodGroup.Fruit),
                new CookedFood("baked","apple",FoodGroup.Fruit),
                new FoodBaseRefType("kiwi", FoodGroup.Fruit)
            };

            SortAndShowList(foodList1);

            // List2: contains the same items as List1, but inserted in different order
            FoodBaseRefType[] foodList2 =
            {
                new FoodBaseRefType("kiwi", FoodGroup.Fruit),
                new FoodBaseRefType("pear", FoodGroup.Fruit),
                new CookedFood("baked", "apple", FoodGroup.Fruit),
                new FoodBaseRefType("apple", FoodGroup.Fruit)
            };

            SortAndShowList(foodList2);

            Console.WriteLine();
        }

        // helper function to display the items of collection
        private static void SortAndShowList(FoodBaseRefType[] list)
        {
            Array.Sort(list, FoodNameComparer.Instance);

            foreach(var item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
        }
    }
}
