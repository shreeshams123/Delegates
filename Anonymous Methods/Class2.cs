using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Anonymous_Methods
{
    public delegate void CalcDelegate(int a, int b);
    internal class Class2
    {
        public static void Add(CalcDelegate a) {
            a(2, 3);
        }
        public static void Sub(CalcDelegate a)
        {
            a(2, 3);
        }
        public static void Main(string[] args)
        {
            Add(delegate (int a, int b)
            {
                Console.WriteLine(a + b);
            });
            Sub(delegate (int a, int b)
            {
                Console.WriteLine(a - b);
            });
            
        } 
    }
}
