using System;
namespace EqualityComparisons
{
    public class OrdinalCompareStrings
    {
        public static void RunDemo()
        {
            string str1 = "computer";
            string str2 = "COMPUTER";
            int result = string.Compare(str1, str2, StringComparison.Ordinal);
            Console.WriteLine($"Compare result for {str1} and {str2}: " + result);
        }
    }
}
