using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lambda_Examples
{
    public delegate string StringOperation(string value);
    
    internal class Class1
    {
        public static void Stringmeth(StringOperation op, string val) {
             string result=op(val);
            Console.WriteLine(result);
        }
        static void Main(string[] args)
        {
            Func<string,string> func = a => { return char.ToUpper(a[0]) + a.Substring(1); };
            Console.WriteLine(func("bob"));
            StringOperation obj1=new StringOperation(x=>x.ToUpper());
            StringOperation obj2 = x => new String(x.Reverse().ToArray());
            StringOperation obj3 = x => x.Replace(' ', '_');
            StringOperation obj4 = x => x.Length.ToString();
            Stringmeth(obj1, "alex");

        }
    }
}
