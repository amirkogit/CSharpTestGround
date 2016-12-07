using System;

namespace EqualityComparisons
{
    public sealed class CookedFood : FoodBaseRefType
    {
        private readonly string _cookingMethod;

        // constructor
        public CookedFood(string cookingMethod, string name, FoodGroup group) 
            : base(name,group)
        {
            this._cookingMethod = cookingMethod;
        }

        public string CookingMethod
        {
            get { return _cookingMethod; }
        }

        public override string ToString()
        {
            return string.Format($"{_cookingMethod}{Name}");
        }

        public static bool operator == (CookedFood x, CookedFood y)
        {
            return object.Equals(x, y);
        }

        public static bool operator != (CookedFood x, CookedFood y)
        {
            return !object.Equals(x, y);
        }

        public override bool Equals(object obj)
        {
            if (!base.Equals(obj))
                return false;

            CookedFood rhs = (CookedFood)obj;
            return this._cookingMethod == rhs._cookingMethod;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode() ^ this._cookingMethod.GetHashCode();
        }
    }
}
