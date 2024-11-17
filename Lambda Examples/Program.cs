using System;

namespace Lambda_Examples
{
    public delegate int MathOperation(int a,int b);
    internal class Program
    {
        public static void Calc(MathOperation op,int x,int y)
        {
            int result = op(x, y);
            Console.WriteLine(result);
        }
        static void Main(string[] args)
        {
            MathOperation add = new MathOperation((a, b) => a + b);
            MathOperation sub= (a,b) => a - b;
            Calc(add, 2, 3);
            Calc(sub, 2, 3);
        }
    }
}
