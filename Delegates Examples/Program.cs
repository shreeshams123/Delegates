using System;

namespace Delegates_Examples
{
    public delegate void AddDelegate(int a, int b);
    public delegate void HelloDelegate(string name);
    class Program
    {
        public void Add(int a,int b)
        {
            Console.WriteLine(a+ b);
        }
        public static void Hello(string name)
        {
            Console.Write("Hello " + name);
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            AddDelegate d = new AddDelegate(p.Add);
            HelloDelegate h = new HelloDelegate(Hello);
            d(2, 3);
            h.Invoke("Rachel");
            
        }
    }
}
