using System;

namespace EqualityComparisons
{
    public class FoodBaseRefType
    {
        private readonly string _name;
        private readonly FoodGroup _group;

        // constructor
        public FoodBaseRefType(string name, FoodGroup group)
        {
            this._name = name;
            this._group = group;
        }

        public string Name
        {
            get { return _name; }
        }

        public override string ToString()
        {
            return _name;
        }

        public static bool operator == (FoodBaseRefType x, FoodBaseRefType y)
        {
            return object.Equals(x, y);
        }

        public static bool operator != (FoodBaseRefType x, FoodBaseRefType y)
        {
            return !object.Equals(x, y);
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            if (ReferenceEquals(obj, this))
                return true;
            if (obj.GetType() != this.GetType())
                return false;

            FoodBaseRefType rhs = obj as FoodBaseRefType;
            return this._name == rhs._name && this._group == rhs._group;
        }

        public override int GetHashCode()
        {
            return this._name.GetHashCode() ^ this._group.GetHashCode();
        }
    }
}
