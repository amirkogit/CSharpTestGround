using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualityComparisions
{
    public class EqualFloats
    {
        public static void RunDemo()
        {
            Console.WriteLine("Equal floats demo:");

            float six = 6.0000000f;
            float nearlysix = 6.0000001f;

            Console.WriteLine(six == nearlysix);
            Console.WriteLine();
        }
    }
}
