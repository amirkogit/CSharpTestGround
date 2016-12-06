﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualityComparisions
{
    public class EqualStrings
    {
        public static void RunDemo()
        {
            Console.WriteLine("Equal strings demo:");

            string str1 = "First String";
            string str2 = string.Copy(str1);

            Console.WriteLine("str1 == " + str1);
            Console.WriteLine("str2 == " + str2);
            Console.WriteLine(str1 == str2);

            Console.WriteLine();
        }
    }
}
