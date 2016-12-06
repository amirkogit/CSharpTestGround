using System;

namespace EqualityComparisons
{
    public class EqualValueTypes
    {
        // helper inner struc
        struct Food
        {
            public Food(string name)
            {
                this._name = name;
            }

            public override string ToString()
            {
                return _name;
            }

            public string Name { get { return _name; } }

            private string _name;
        }


        public static void RunDemo()
        {
            Console.WriteLine("EqualValueTypes demo: Demonstrates that == doesn't work for " +
                               "non primitive value types out of the box!");

            Food banana = new Food("banana");
            Food banana2 = new Food("banana");
            Food chocolate = new Food("chocolate");

            Console.WriteLine("banana.Equals(chocolate): " + banana.Equals(chocolate));
            Console.WriteLine("banana.Equals(banana2): " + banana.Equals(banana2));

            // this line won't compile because no == overload has been provided for Food struct
            // and Food is a valuetype
            //Console.WriteLine(banana == chocolate);
            Console.WriteLine("banana == chocolate won't compile!");

            Console.WriteLine();
        }
    }
}
