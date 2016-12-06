using System;

namespace EqualityComparisons
{
    public class EqualFloats
    {
        public static void RunDemo()
        {
            Console.WriteLine("Equal floats demo:");

            float six = 6.0000000f;
            float nearlysix = 6.0000001f;

            Console.WriteLine(six == nearlysix); // returns TRUE ??
                                                 // Not a good idea to use == for float comparisions
            Console.WriteLine();
        }
    }
}
