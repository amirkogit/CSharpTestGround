using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    public class ForeachReadOnlyDemo
    {
        public static void RunDemo()
        {
            Console.WriteLine("ForeachReadOnlyDemo: Demonstrates that you cannot replace array elements using foreach");

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

            MakeDaysPluralUsingForLoop(daysofWeek);

            Console.WriteLine("Plural days:");
            foreach (var day in daysofWeek)
                Console.WriteLine(day);

            Console.WriteLine();
        }

        private static void MakeDaysPluralUsingForLoop(string[] daysOfWeek)
        {
            for(int i = 0; i < daysOfWeek.Length; i++)
            {
                string day = daysOfWeek[i];
                daysOfWeek[i] = day + "s";
            }
        }

        private static void MakeDaysPluralUsingForEach(string[] daysOfWeek)
        {
            foreach(string day in daysOfWeek)
            {
                // The following won't compile
                //day = day + 's';
            }
        }
    }
}
