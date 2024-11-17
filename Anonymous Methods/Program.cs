using System;

namespace Anonymous_Methods
{
    public delegate void NameDelegate(string name);
     class Program
    {
        static void Main(string[] args)
        {
            NameDelegate d = delegate (string name)
            {
                Console.WriteLine(name);
            };
            
            d.Invoke("alex");
        }
    }
}


