﻿using System;

namespace EqualityComparisons
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Equality-Comparisions demo:\n");

            EqualButtons.RunDemo();
            EqualFloats.RunDemo();
            EqualInts.RunDemo();
            EqualStrings.RunDemo();
            FoodEquals.RunDemo();
            StringEquals.RunDemo();
            IEquatableInt.RunDemo();
            FoodEqualsButton.RunDemo();
            EqualityInt.RunDemo();
            EqualityButtons.RunDemo();
            EqualityStrings.RunDemo();
            EqualValueTypes.RunDemo();
            EqualTuples.RunDemo();
            Inheritance.RunDemo();
            Generics.RunDemo();
            ValueTypeEquality.RunDemo();
            RefTypeEquality.RunDemo();
            StringIntCompare.RunDemo();
            CalorieCountCompare.RunDemo();
        }
    }
}
