using System;
using System.Windows.Forms;

namespace EqualityComparisons
{
    public class EqualityButtonsDemo
    {
        public static void RunDemo()
        {
            Console.WriteLine("Equality buttons demo : Demonstrates == and Equals() for Buttons");

            Button button1 = new Button();
            button1.Text = "Button1";

            Button button2 = new Button();
            button2.Text = "Button2";

            Console.WriteLine("Operator: " + AreButtonsEqualOp(button1, button2));
            Console.WriteLine("Method: " + AreButtonsEqualMethod(button1, button2));

            Console.WriteLine();
        }

        static bool AreButtonsEqualOp(Button x, Button y)
        {
            return x == y; // returns FALSE: evaluates reference equality
        }

        static bool AreButtonsEqualMethod(Button x, Button y)
        {
            return x.Equals(y); // returns FALSE: evaluates reference equality
        }
    }
}
