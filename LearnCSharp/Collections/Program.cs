using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Collections demo:\n");

            EnumerateArrayDemo.RunDemo();
            ForeachReadOnlyDemo.RunDemo();
            ChangePersonDemo.RunDemo();
        }
    }
}
