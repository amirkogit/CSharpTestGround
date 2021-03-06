﻿using System;
using System.Windows.Forms;

namespace EqualityComparisons
{
    public class FoodEqualsButtonDemo
    {
        public static void RunDemo()
        {
            Console.WriteLine("Food equals button demo:");

            Food food = new Food("chocolate");
            Button button = new Button();
            button.Text = "Button text";

            bool result = food.Equals(button);
            Console.WriteLine($"food.Equals(button): {result}");
            Console.WriteLine();
        }
    }
}
