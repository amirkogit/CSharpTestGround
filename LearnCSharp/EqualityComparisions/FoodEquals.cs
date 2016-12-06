using System;

namespace EqualityComparisons
{
    public class Food
    {
        public string Name
        {
            get
            {
                return _name;
            }
        }

        public Food(string name)
        {
            this._name = name;
        }

        public override string ToString()
        {
            return _name;
        }

        private string _name;
    }

    public class FoodEquals
    {
        public static void RunDemo()
        {
            Console.WriteLine("Food equals demo:");

            Food banana = new Food("banana");
            Food banana2 = new Food("banana");
            Food choclate = new Food("chocolate");

            Console.WriteLine(banana.Equals(choclate)); // returns FALSE : evaluates reference equality
            Console.WriteLine(banana.Equals(banana2)); // returns FALSE : evaluates reference equality

            Console.WriteLine(banana.Equals(null)); // returns FALSE : evaluates reference equality
            Console.WriteLine(object.Equals(banana,null)); // returns FALSE : evaluates reference equality
            Console.WriteLine(object.Equals(null,banana)); // returns FALSE : evaluates reference equality
            Console.WriteLine(object.Equals(null,null)); // returns TRUE : null equals null always evaluates to TRUE

            Console.WriteLine();
        }
    }
}
