using System;
using System.Collections.Generic;

namespace EqualityComparisons
{
    public class EqualityComparerDemo
    {
        public static void RunDemo()
        {
            Console.WriteLine("EqualityComparerDemo: Demonstrates implementing an equality\n" + 
                              "comparer for the struct (FoodItemValueType).\n");

            var foodItems = new HashSet<FoodItemValueType>(FoodItemEqualityComparer.Instance);
            foodItems.Add(new FoodItemValueType("apple", FoodGroup.Fruit));
            foodItems.Add(new FoodItemValueType("pear", FoodGroup.Fruit));
            foodItems.Add(new FoodItemValueType("pineApple", FoodGroup.Fruit));
            foodItems.Add(new FoodItemValueType("Apple", FoodGroup.Fruit)); 

            foreach(var item in foodItems)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
        }
    }
}
