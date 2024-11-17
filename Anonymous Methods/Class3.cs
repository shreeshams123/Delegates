using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Anonymous_Methods
{
    public delegate void Sortlist(List<int> list);
    internal class Class3
    {
        public static void Sortasc(Sortlist s)
        {
            List<int> list = new List<int>() { 2, 5, 3, 7, 8 };
            s(list);
            Console.WriteLine(string.Join(",",list));
        }
        public static void Sortdesc(Sortlist s)
        {
            List<int> list = new List<int>() { 2, 5, 3, 7, 8 };
            s(list);
            Console.WriteLine(string.Join(",", list));
        }
        static void Main(string[] args)
        {
            Sortasc(delegate (List<int> list)
            {
                list.Sort();
            });
            Sortdesc(delegate (List<int> list)
            {
                list.Sort();
                list.Reverse();
            });
            List<int> list = new List<int>() { 2, 5, 3, 7, 8 };
            var newlist=list.OrderByDescending(x => x).ToList();
            foreach (int x in newlist)
            {
                Console.WriteLine(x);
            }
        }
    }
}
