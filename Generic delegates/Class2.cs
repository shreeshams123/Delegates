using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Generic_delegates
{
    internal class Class2
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 1,2,3,4,5};
            Func<int,int> act = x => (x * x);
            var newlist = list.Select(act).ToList();
            foreach (var item in newlist)
            {
                Console.WriteLine(item);
            }
        }
    }
}
