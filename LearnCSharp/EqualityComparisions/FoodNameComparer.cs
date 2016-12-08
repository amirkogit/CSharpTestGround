using System;
using System.Collections.Generic;

namespace EqualityComparisons
{
    // Comparer class that compares the Name field of FoodBaseRefType class
    public class FoodNameComparer : Comparer<FoodBaseRefType>
    {
        private static FoodNameComparer _instance = new FoodNameComparer();

        public static FoodNameComparer Instance
        {
            get { return _instance; }
        }

        // private constructor: make this class a Singleton
        private FoodNameComparer() { }

        public override int Compare(FoodBaseRefType x, FoodBaseRefType y)
        {
            // check the following for consistency with the output result values
            if (x == null && y == null)
                return 0;
            if (x == null)
                return -1;
            if (y == null)
                return 1;

            // now the actual compare logic
            return string.Compare(x.Name, y.Name, StringComparison.CurrentCulture);
        }
    }
}
