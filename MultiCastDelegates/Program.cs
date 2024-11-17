using System;

namespace MultiCastDelegates
{
    public delegate void Rect(int a, int b);
    internal class Program
    {
        public void Area(int length,int breadth)
        {
            Console.WriteLine("Area is " + length * breadth);
        }
        public void Perimeter(int length,int breadth)
        {
            Console.WriteLine("Perimeter is "+(2 + (length * breadth)));
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            Rect r = new Rect(p.Area);
            r += p.Perimeter;
            r.Invoke(2, 3);

        }
    }
}
