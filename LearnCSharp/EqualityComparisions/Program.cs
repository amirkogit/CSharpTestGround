using System;

namespace EqualityComparisons
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Equality-Comparisions demo:\n");

            EqualButtonsDemo.RunDemo();
            EqualFloatsDemo.RunDemo();
            EqualIntsDemo.RunDemo();
            EqualStringsDemo.RunDemo();
            FoodEqualsDemo.RunDemo();
            StringEqualsDemo.RunDemo();
            IEquatableIntDemo.RunDemo();
            FoodEqualsButtonDemo.RunDemo();
            EqualityIntDemo.RunDemo();
            EqualityButtonsDemo.RunDemo();
            EqualityStringsDemo.RunDemo();
            EqualValueTypesDemo.RunDemo();
            EqualTuplesDemo.RunDemo();
            InheritanceDemo.RunDemo();
            GenericsDemo.RunDemo();
            ValueTypeEqualityDemo.RunDemo();
            RefTypeEqualityDemo.RunDemo();
            StringIntCompareDemo.RunDemo();
            CalorieCountCompareDemo.RunDemo();
            OrdinalCompareStringsDemo.RunDemo();
            CompareStringsDemo.RunDemo();
            StringPoolingDemo.RunDemo();
            SortItemsWithComparerDemo.RunDemo();
            InconsistentSortingDemo.RunDemo();
            EqualityComparerDemo.RunDemo();
            StringComparersDemo.RunDemo();
            FoodItemNameOnlyEqualityComparerDemo.RunDemo();
            FoodItemEqualityComparer2Demo.RunDemo();
            StructuralEqualityDemo.RunDemo();
        }
    }
}
