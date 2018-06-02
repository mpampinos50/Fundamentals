using System;
using System.Collections.Generic;
using System.Text;

namespace Fundamentals.Samples
{
    class ReferenceTypesSample
    {
        public static void Demo()
        {
            Console.WriteLine($"Reference Types{Environment.NewLine}");

            int refArg = 100;
            RefMethod(ref refArg);
            Console.WriteLine(refArg);

            // int outArg; // can be used as well
            OutMethod(out int outArg);
            Console.WriteLine(outArg);

            int inArg = 300;
            InMethod(in inArg);
            Console.WriteLine(inArg);

            Console.WriteLine($"------------------------{Environment.NewLine}");
        }

        public static void RefMethod(ref int input)
        {
            input++;
        }

        public static void OutMethod(out int input)
        {
            input = 200;
        }

        public static void InMethod(in int input)
        {
            // input = 1000; // cannot assign value, it's readonly
            var newValue = input;
        }
    }
}
