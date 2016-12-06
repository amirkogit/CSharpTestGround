using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualityComparisions
{
    public class IEquatableInt
    {
        public static void RunDemo()
        {
            Console.WriteLine("IEquatable int demo:");

            int three = 3;
            int threeAgain = 3;
            int four = 4;

            Console.WriteLine(three.Equals(threeAgain)); // returns TRUE : evaluates to value equality - implicitly uses IEquatable<int>
            Console.WriteLine(three.Equals(four)); // returns FALSE : evaluates to value equality
            
            Console.WriteLine();
        }
    }
}
