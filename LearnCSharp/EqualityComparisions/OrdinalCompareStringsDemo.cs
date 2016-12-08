using System;
namespace EqualityComparisons
{
    public class OrdinalCompareStringsDemo
    {
        public static void RunDemo()
        {
            Console.WriteLine("OrdinalCompareStrings demo:");

            string str1 = "computer";
            string str2 = "COMPUTER";
            int result = string.Compare(str1, str2, StringComparison.Ordinal);
            Console.WriteLine($"Compare result for {str1} and {str2}: " + result);

            Console.WriteLine();
        }
    }
}
