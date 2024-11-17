using System;
using System.Collections.Generic;
using System.Text;

namespace Anonymous_Methods
{
    public delegate void Show(string color);
    internal class Class1
    {
        public static void Identity(Show mycolor, string color) {
            color = "Black";
            mycolor(color);
        }
        static void Main(string[] args)
        {
            Identity(delegate (string color) { Console.WriteLine("Color is " + color);},"Green");
        }
    }
}
