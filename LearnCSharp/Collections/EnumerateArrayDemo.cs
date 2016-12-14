using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    public class EnumerateArrayDemo
    {
        public static void RunDemo()
        {
            Console.WriteLine("EnumerateArrayDemo: Compares using for and foreach to enumerate arrays");

            string[] daysofWeek =
            {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
            };

            Console.WriteLine("Enumerating using foreach");
            foreach(var day in daysofWeek)
                Console.WriteLine(day);

            Console.WriteLine();
            Console.WriteLine("Enumerating using for loop");
            for(int i = 0; i < daysofWeek.Length; i++)
            {
                Console.WriteLine(daysofWeek[i]);
            }
        }
    }
}
