using System;
using System.Collections.Generic;

namespace EqualityComparisons
{
    // Comparer class to compare value type objects
    public class FoodItemEqualityComparer : EqualityComparer<FoodItemValueType>
    {
        private static readonly FoodItemEqualityComparer _instance = new FoodItemEqualityComparer();

        public static FoodItemEqualityComparer Instance
        {
            get { return _instance; }
        }

        // private constructor : make this class a Singleton
        private FoodItemEqualityComparer() { }

        public override bool Equals(FoodItemValueType x, FoodItemValueType y)
        {
            return x.Name.ToUpperInvariant() == y.Name.ToUpperInvariant() &&
                   x.Group == y.Group;
        }

        public override int GetHashCode(FoodItemValueType obj)
        {
            return obj.Name.ToUpperInvariant().GetHashCode() ^ obj.Group.GetHashCode();
        }
    }
}
