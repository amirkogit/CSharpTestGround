using System;

namespace EqualityComparisons
{
    public class EqualityInt
    {
        public static void RunDemo()
        {
            Console.WriteLine("Equality int demo: Demonstrates == and Equals() for integers");

            Console.WriteLine("Operator: " + AreIntsEqualOp(3,3));
            Console.WriteLine("Method: " + AreIntsEqualMethod(3,3));

            Console.WriteLine();
        }

        static bool AreIntsEqualOp(int x, int y)
        {
            return x == y; // returns TRUE : evaluates value equality
        }

        // Peeking into IL Diassembler
        // ------------------------------------------------------------

        //.method private hidebysig static bool AreIntsEqualOp(int32 x,
        //                                                int32 y) cil managed
        //{
        //// Code size       5 (0x5)
        //.maxstack  8
        //IL_0000:  ldarg.0
        //IL_0001:  ldarg.1
        //IL_0002:  ceq
        //IL_0004:  ret
        //} // end of method EqualityInt::AreIntsEqualOp

        static bool AreIntsEqualMethod(int x, int y)
        {
            return x.Equals(y); // returns TRUE : evaluates value equality
        }

        // Peeking into IL Diassembler
        // ------------------------------------------------------------

        //.method private hidebysig static bool AreIntsEqualMethod(int32 x,
        //                                            int32 y) cil managed
        //{
        //// Code size       9 (0x9)
        //.maxstack  8
        //IL_0000:  ldarga.s x
        //IL_0002:  ldarg.1
        //IL_0003:  call instance bool[mscorlib] System.Int32::Equals(int32)
        //IL_0008:  ret
        //} // end of method EqualityInt::AreIntsEqualMethod
    }
}
