using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualityComparisions
{
    public class EqualInts
    {
        public static void RunDemo()
        {
            Console.WriteLine("Equal int demo:");

            int three = 3;
            int threeAgain = 3;
            bool intCmp = (three == threeAgain); // returns TRUE
            Console.WriteLine($"Compare ints: {intCmp}"); 

            bool objCmp = ((object)three == (object)threeAgain); // returns FALSE
            Console.WriteLine($"Compare objects: {objCmp}");

            bool iComparableCmp = 
                ((IComparable<int>)three == (IComparable<int>)threeAgain); // returns FALSE
            Console.WriteLine($"Compare interfaces: {iComparableCmp}");

            Console.WriteLine();
        }
    }
}
