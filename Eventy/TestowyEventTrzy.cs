using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public delegate void DelegatDlaTestowychEventow(object sender, EventArgs e);

namespace ConsoleApp48.Eventy
{

    public class TestowyEventTrzy
    {
        public event DelegatDlaTestowychEventow TrzeciTestowyEventEvent;

        public void ReiseEvent()
        {
            Console.WriteLine("Zdarzenie jest wywołame");
            Onvent();
        }

        public virtual void Onvent()
        {
            if(TrzeciTestowyEventEvent != null)
            {
                EventArgs e = new EventArgs();
                TrzeciTestowyEventEvent(this, e);
            }
        }

        public void EventHandlerMEthod(object sender, EventArgs e)
        {
            Console.WriteLine("Zdarzenie zostało obsłużone");
        }

        //public static void Main()
        //{
        //    TestowyEventTrzy testowyEventTrzy = new TestowyEventTrzy();

        //    testowyEventTrzy.TrzeciTestowyEventEvent += testowyEventTrzy.EventHandlerMEthod;
        //    testowyEventTrzy.ReiseEvent();

        //    Console.ReadLine(); 

        //}
    }
}
