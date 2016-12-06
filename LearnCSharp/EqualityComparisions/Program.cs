using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualityComparisions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Equality-Comparisions demo:\n");

            EqualButtons.RunDemo();
            EqualFloats.RunDemo();
            EqualInts.RunDemo();
            EqualStrings.RunDemo();
        }
    }
}
