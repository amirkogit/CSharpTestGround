using System;
using System.Windows.Forms;

namespace EqualityComparisons
{
    public class EqualButtonsDemo
    {
        public static void RunDemo()
        {
            Console.WriteLine("Check if two buttons are equal:");

            Button button1 = new Button();
            button1.Text = "Button 1";

            Button button2 = new Button();
            button2.Text = "Button 2";

            Console.WriteLine(button1 == button2); // returns FALSE --> checked reference equality
            Console.WriteLine();
        }
    }
}
