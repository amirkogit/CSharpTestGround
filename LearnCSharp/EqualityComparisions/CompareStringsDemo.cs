using System;
using System.Threading;

namespace EqualityComparisons
{
    public class CompareStringsDemo
    {
        public static void RunDemo()
        {
            Console.WriteLine("Current culture: " + Thread.CurrentThread.CurrentCulture);

            DisplayAllComparisons("apple", "PINEAPPLE");
            Console.WriteLine();

            // U+00DF is eszett
            DisplayAllComparisons("Stra\u00dfe", "Strasse");
            Console.WriteLine();

            // a-umlaut is U+00E4
            // umlaut (combining diaeresis) is U+0308
            DisplayAllComparisons("erkl\u00e4ren", "erkla\u0308ren");
            Console.WriteLine();

            Console.WriteLine();
        }

        // display all possible comparison results for two strings
        private static void DisplayAllComparisons(string str1, string str2)
        {
            DisplayComparison(str1, str2, StringComparison.Ordinal);
            DisplayComparison(str1, str2, StringComparison.OrdinalIgnoreCase);
            Console.WriteLine();
            DisplayComparison(str1, str2, StringComparison.InvariantCulture);
            DisplayComparison(str1, str2, StringComparison.InvariantCultureIgnoreCase);
            Console.WriteLine();
            DisplayComparison(str1, str2, StringComparison.CurrentCulture);
            DisplayComparison(str1, str2, StringComparison.CurrentCultureIgnoreCase);
        }

        // helper function to display the result of two string comparison based on supplied
        // StringComparision value
        private static void DisplayComparison(string str1, string str2, StringComparison comparison)
        {
            int result = string.Compare(str1, str2, comparison);
            Console.WriteLine($"{str1} {str2} {GetCompareSymbol(result)}    ({result}, {comparison})");
        }

        // helper function go get the compare symbol
        private static string GetCompareSymbol(int compareResult)
        {
            if (compareResult == 0)
                return "==";
            else if (compareResult < 1)
                return "< ";
            else
                return "> ";
        }
    }
}
