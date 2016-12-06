﻿using System;

namespace EqualityComparisions
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
        }
    }
}