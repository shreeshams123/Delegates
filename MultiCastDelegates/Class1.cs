using System;
using System.Collections.Generic;
using System.Text;

namespace MultiCastDelegates
{
    public delegate void MathDelegate(int a, int b);
    internal class Class1
    {
        public void Add(int a,int b)
        {
            Console.WriteLine("Addition is " + (a + b));
        }
        public void Sub(int a, int b)
        { 
            Console.WriteLine("Substraction is " +( a - b)); 
        }
        public static void Main(string[] args)
        {
            Class1 c = new Class1();
            MathDelegate m= new MathDelegate(c.Add);
            m += c.Sub;
            m.Invoke(3, 2);
        }
    }
}
