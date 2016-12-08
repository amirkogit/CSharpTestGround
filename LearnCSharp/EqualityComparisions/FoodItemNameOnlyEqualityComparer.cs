using System;
using System.Collections.Generic;

namespace EqualityComparisons
{
    // Comparer class that uses only Name field to do quality comparision
    class FoodItemNameOnlyEqualityComparer : EqualityComparer<FoodItemValueType>
    {
        private static FoodItemNameOnlyEqualityComparer _instance =
            new FoodItemNameOnlyEqualityComparer();
        public static FoodItemNameOnlyEqualityComparer Instance
        {
            get { return _instance; }
        }

        // private constructor : make this class a Singleton class
        private FoodItemNameOnlyEqualityComparer() { }

        #region EqualityComparer overrides
        // NOTE: make sure to use the consistent checks in Equals() and GetHashCode():
        // Either use both Name and Group or Name only or Group only
        public override bool Equals(FoodItemValueType x, FoodItemValueType y)
        {
            return x.Name == y.Name;

            //return x.Name == y.Name && x.Group == y.Group; 
        }

        public override int GetHashCode(FoodItemValueType obj)
        {
            return obj.Name.GetHashCode();

            //return obj.Name.GetHashCode() ^ obj.Group.GetHashCode();
        }
        #endregion
    }
}
