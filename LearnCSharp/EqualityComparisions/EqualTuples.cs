using System;

namespace EqualityComparisons
{
    public class EqualTuples
    {
        public static void RunDemo()
        {
            Console.WriteLine("EqualTuples demo: Demonstrates that == and object.Equals() are inconsistent for tuples!");

            Tuple<int, int> tuple1 = Tuple.Create(1, 2);
            Tuple<int, int> tuple2 = Tuple.Create(1, 2);

            Console.WriteLine("Reference: " + ReferenceEquals(tuple1, tuple2)); // returns FALSE : evaluates reference equality
            Console.WriteLine("Method: " + tuple1.Equals(tuple2)); // returns TRUE : evaluates value equality  
            Console.WriteLine("Operator: " + (tuple1 == tuple2)); // returns FALSE : evaluates reference equality because no == overload is present in Tuple

            Console.WriteLine();
        }
    }
}
