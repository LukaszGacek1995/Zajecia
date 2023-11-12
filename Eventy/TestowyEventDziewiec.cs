using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp48.Eventy
{
    public class TestowyEventDziewiec
    {
        public event EventHandler NazwaEventuNazwa;

        public void ReciveDate(string data)
        {
            Console.WriteLine("Odebrano date "+ data);

            OnDataReceived();
        }

        public virtual void OnDataReceived()
        {
            NazwaEventuNazwa?.Invoke (this, EventArgs.Empty);
        }
    }

    public class ProgramDlaDevice
    {

        //public static void Main()
        //{
        //    TestowyEventDziewiec testowyEventDziewiec = new TestowyEventDziewiec();

        //    testowyEventDziewiec.NazwaEventuNazwa += Handler_Device;

        //    testowyEventDziewiec.OnDataReceived("Dane");

        //    Console.ReadLine();
        //}

        public static void Handler_Device(object sender, EventArgs e)
        {
            Console.WriteLine("Zdarzenie NazwaEventu zostało obsłużone");
        }
    }
}
