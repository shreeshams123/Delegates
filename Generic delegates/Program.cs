using System;

namespace Generic_delegates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<int, int,int> addnums = (a, b) => { return a + b; };
            Console.WriteLine(addnums(1, 2));
            Action<string> str = name => { Console.WriteLine(name.Length); };
            str("Hello");
            Predicate<string> check = value => { return value.Length== 5; };
            Console.WriteLine(check("Hello"));
        }
    }
}
