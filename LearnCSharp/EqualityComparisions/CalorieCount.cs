using System;

namespace EqualityComparisons
{
    public struct CalorieCount : IComparable<CalorieCount>, IEquatable<CalorieCount>, IComparable
    {
        private float _value;
        public float Value
        {
            get { return _value; }
        }

        // constructor
        public CalorieCount(float value)
        {
            this._value = value;
        }

        public override string ToString()
        {
            return _value + " cal";
        }

        // IComparable<T>
        public int CompareTo(CalorieCount other)
        {
            return this._value.CompareTo(other._value);
        }

        // IComparable(legacy interface)
        public int CompareTo(object obj)
        {
            if (obj == null)
                throw new ArgumentNullException("obj");
            if (!(obj is CalorieCount))
                throw new ArgumentException("Expected CalorieCount instance", "obj");
            return CompareTo((CalorieCount)obj);
        }

        // IEquatable<T>
        public bool Equals(CalorieCount other)
        {
            return _value == other._value;
        }

        // Also need to implement overriden version of Equals
        public override bool Equals(object obj)
        {
            // as the parameter is object(type safety is lost). So need to do some
            // extra checks if the object is a valid one
            if (obj == null)
                return false;
            if(!(obj is CalorieCount))
                return false;
            return _value == ((CalorieCount)obj)._value;
        }

        // As we override for Object.Equals(), we also need to override Object.GetHashCode()
        public override int GetHashCode()
        {
            return _value.GetHashCode();
        }

        // Implement overrides for all equality and comparision operators
        // ==, !=, <, <=, >, >=
        public static bool operator == (CalorieCount x, CalorieCount y)
        {
            // As CalorieCount is a value type, no need to use object.Equals()
            return x._value == y._value;
        }

        public static bool operator != (CalorieCount x, CalorieCount y)
        {
            // As CalorieCount is a value type, no need to use object.Equals()
            return x._value != y._value;
        }

        public static bool operator < (CalorieCount x, CalorieCount y)
        {
            return x._value < y._value;
        }

        public static bool operator <= (CalorieCount x, CalorieCount y)
        {
            return x._value <= y._value;
        }

        public static bool operator > (CalorieCount x, CalorieCount y)
        {
            return x._value > y._value;
        }

        public static bool operator >= (CalorieCount x, CalorieCount y)
        {
            return x._value >= y._value;
        }
    }
}
