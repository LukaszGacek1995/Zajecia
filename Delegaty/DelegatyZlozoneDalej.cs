using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp48.Delegaty
{
    delegate void CallbackDelegate(string message);

    class Notifier
    {
        public void Notify(string message, CallbackDelegate callback)
        {
            Console.WriteLine("Notification: " + message);
            callback("Callback executed.");
        }
    }

    //class Program1234
    //{
    //    static void CallbackMethod(string response)
    //    {
    //        Console.WriteLine("Callback received: " + response);
    //    }

    //    static void Main(string[] args)
    //    {
    //        Notifier notifier = new Notifier();

    //        CallbackDelegate callbackDelegate = CallbackMethod;

    //        notifier.Notify("Hello, delegates!", callbackDelegate);

    //        Console.ReadLine();
    //    }
    //}
}
