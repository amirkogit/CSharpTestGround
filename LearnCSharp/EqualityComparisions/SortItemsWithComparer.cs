using System;
using System.Collections.Generic;

namespace EqualityComparisons
{
    public class SortItemsWithComparer
    {
        public static void RunDemo()
        {
            Console.WriteLine("SortItemsWithComparer demo: Demonstrates using a comparer to change how Food instances are sorted");

            FoodBaseRefType[] listFoods = {
                new FoodBaseRefType("orange", FoodGroup.Fruit),
                new FoodBaseRefType("banana", FoodGroup.Fruit),
                new FoodBaseRefType("pear", FoodGroup.Fruit),
                new FoodBaseRefType("apple", FoodGroup.Fruit)
            };

            // this code will crash the application because we have not passed a necessary comparer to Sort() method!
            //Array.Sort(listFoods);

            // correct way:
            Array.Sort(listFoods, FoodNameComparer.Instance);

            foreach(var item in listFoods)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
        }
    }
}
