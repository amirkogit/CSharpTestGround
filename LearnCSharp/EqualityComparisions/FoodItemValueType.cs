using System;
namespace EqualityComparisons
{
    public enum FoodGroup
    {
        Meat,
        Fruit,
        Vegetables,
        Sweets
    }

    public struct FoodItemValueType : IEquatable<FoodItemValueType>
    {
        private readonly string _name;
        private readonly FoodGroup _group;

        public FoodItemValueType(string name, FoodGroup group)
        {
            this._name = name;
            this._group = group;
        }

        public string Name
        {
            get { return _name; }
        }

        public FoodGroup Group
        {
            get { return _group; }
        }

        public override string ToString()
        {
            return _name;
        }

        public bool Equals(FoodItemValueType other)
        {
            return this._name == other._name &&
                   this._group == other._group; 
        }

        public override bool Equals(object obj)
        {
            if(obj is FoodItemValueType)
            {
                return Equals((FoodItemValueType)obj);
            }
            else
            {
                return false;
            }
        }

        public static bool operator == (FoodItemValueType lhs, FoodItemValueType rhs)
        {
            return lhs.Equals(rhs);
        }

        public static bool operator != (FoodItemValueType lhs, FoodItemValueType rhs)
        {
            return !lhs.Equals(rhs);
        }

        public override int GetHashCode()
        {
            return _name.GetHashCode() ^ _group.GetHashCode();
        }
    }
}
