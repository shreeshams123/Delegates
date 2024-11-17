using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;

namespace Generic_delegates
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            Func<int, int, int> func = (a, b) => a * b;
            Console.WriteLine(func(2, 6));
            Action<string> act = value => Console.WriteLine(value.Length.ToString());
            act("Hello");

            Predicate<string> pred = value =>
            {
                string val = new string(value.Reverse().ToArray());
                return value == val;
            };
            Console.WriteLine(pred("MadaM"));
        }
    }
}
