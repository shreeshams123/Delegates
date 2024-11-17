using System;
using System.Collections.Generic;
using System.Text;

namespace Delegates_Examples
{
    public delegate void NotifyDelegate(string message);
    class Demo
    {
        public void SendNotfication(string message, NotifyDelegate notify)
        {
            notify(message);
        }
    }
    internal class Class1
    {
        public static void EmailNotify(string message)
        {
            
            Console.WriteLine(message);
        }
        public static void SmsNotify(string message)
        {
            message = "Message sent by Sms";
            Console.WriteLine(message);
        }
            static void Main(string[] args)
            {
            Demo demo = new Demo();
            NotifyDelegate n = new NotifyDelegate(EmailNotify);
            demo.SendNotfication("Email sent", n);
            NotifyDelegate m = new NotifyDelegate(SmsNotify);
            demo.SendNotfication("Sms sent", m);
            }
    }
}
