using System;

namespace EqualityComparisons
{
    public class RefTypeEquality
    {
        public static void RunDemo()
        {
            Console.WriteLine("RefTypeEquality demo: Demonstrates two reference types- \n" +  
                              "FoodBase(base type) and CookedFood (sealed derived type)\n"+
                              "for which equality has been implemented correctly\n");

            FoodBaseRefType apple = new FoodBaseRefType("apple", FoodGroup.Fruit);
            CookedFood stewedApple = new CookedFood("stewed", "apple", FoodGroup.Fruit);
            CookedFood bakedApple = new CookedFood("baked", "apple", FoodGroup.Fruit);
            CookedFood stewedApple2 = new CookedFood("stewed", "apple", FoodGroup.Fruit);
            FoodBaseRefType apple2 = new FoodBaseRefType("apple", FoodGroup.Fruit);

            DisplayWhetherEqual(apple, stewedApple);
            DisplayWhetherEqual(stewedApple, bakedApple);
            DisplayWhetherEqual(stewedApple, stewedApple2);
            DisplayWhetherEqual(apple, apple2);
            DisplayWhetherEqual(apple, apple);

            Console.WriteLine();
        }

        // helper function to check equality
        static void DisplayWhetherEqual(FoodBaseRefType food1, FoodBaseRefType food2)
        {
            if(food1 == food2)
                Console.WriteLine(string.Format($"{food1} == {food2}"));
            else
                Console.WriteLine(string.Format($"{food1} != {food2}"));
        }
    }
}
