using System;
using System.Collections.Generic;

namespace EqualityComparisons
{
    // Comparer class to compare FoodItemValueType objects that uses microsoft's
    // StringComparer class to override Equals() and GetHashCode()
    public class FoodItemEqualityComparer2 : EqualityComparer<FoodItemValueType>
    {
        private static readonly FoodItemEqualityComparer2 _instance =
            new FoodItemEqualityComparer2();

        public static FoodItemEqualityComparer2 Instance
        {
            get { return _instance; }
        }

        // make this class a Singleton
        private FoodItemEqualityComparer2() { }
        public override bool Equals(FoodItemValueType x, FoodItemValueType y)
        {
            //return StringComparer.OrdinalIgnoreCase.Equals(x.Name, y.Name)
            //       && x.Group == y.Group;

            return StringComparer.Ordinal.Equals(x.Name, y.Name) &&
                   x.Group == y.Group;
        }

        public override int GetHashCode(FoodItemValueType obj)
        {
            //return StringComparer.OrdinalIgnoreCase.GetHashCode(obj.Name) ^ obj.Group.GetHashCode();

            return StringComparer.Ordinal.GetHashCode(obj.Name) ^ obj.Group.GetHashCode();
        }
    }
}
