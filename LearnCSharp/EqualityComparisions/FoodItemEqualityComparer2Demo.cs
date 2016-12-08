using System;
using System.Collections.Generic;

namespace EqualityComparisons
{
    public class FoodItemEqualityComparer2Demo
    {
        public static void RunDemo()
        {
            Console.WriteLine("FoodItemEqualityCompare2Demo: Uses built in StringComparer to generate hash codes");

            // NOTE: here the number of items inserted depends on how FoodItemEqualityComparer2 is generating the
            // hash code values. It it uses StringComparer.Ordinal, HashSet will treat 'apple' and 'Apple' differently 
            // as they will have different hash code values

            var foodItems = new HashSet<FoodItemValueType>(FoodItemEqualityComparer2.Instance);

            foodItems.Add(new FoodItemValueType("apple", FoodGroup.Fruit));
            foodItems.Add(new FoodItemValueType("pear", FoodGroup.Fruit));
            foodItems.Add(new FoodItemValueType("pineApple", FoodGroup.Fruit));
            foodItems.Add(new FoodItemValueType("Apple", FoodGroup.Fruit));

            foreach(var fooditem in foodItems)
            {
                Console.WriteLine(fooditem);
                Console.WriteLine("Hashcode: " + fooditem.GetHashCode());
            }
               
            Console.WriteLine();
        }
    }
}
