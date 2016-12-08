using System;

namespace EqualityComparisons
{
    public class ValueTypeEqualityDemo
    {
        public static void RunDemo()
        {
            Console.WriteLine("Equality for value types demo: Demonstrates a value type for" + 
                              " which equality has been implemented");

            FoodItemValueType banana = new FoodItemValueType("banana", FoodGroup.Fruit);
            FoodItemValueType banana2 = new FoodItemValueType("banana", FoodGroup.Fruit);
            FoodItemValueType chocolate = new FoodItemValueType("chocolate", FoodGroup.Sweets);

            Console.WriteLine("banana == banana2: " + (banana == banana2)); // returns TRUE : value equality
            Console.WriteLine("banana2 == chocolate: " + (banana2 == chocolate)); // returns FALSE : value equality
            Console.WriteLine("chocolate == banana: " + (chocolate == banana)); // returns FALSE : value equality

            Console.WriteLine();
        }
    }
}
