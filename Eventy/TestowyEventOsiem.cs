using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp48.Eventy
{
    internal class TestowyEventOsiem
    {
        public event EventHandler<string> SomthinHappend;

        public void DoSomething()
        {
            Console.WriteLine("Something is happening");
            OnSomethingHappened("something happend");
        }
        protected virtual void OnSomethingHappened(string message)
        {
            SomthinHappend?.Invoke(this, message);
        }

    }


    internal class Subsciber
    {
        public void HandleEvent(object sender, string messege)
        {
            Console.WriteLine($"Subsciber eloo {messege}");
        }
    }

    internal class ProgramGlowna
    {

        //public static void Main()
        //{
        //    TestowyEventOsiem testowyEventOsiem = new TestowyEventOsiem();
        //    Subsciber subsciber = new Subsciber();

        //    testowyEventOsiem.SomthinHappend += subsciber.HandleEvent;


        //}
    }
}
