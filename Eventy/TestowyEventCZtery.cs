using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public delegate void ClickEventHandler(object sender, EventArgs e);
namespace ConsoleApp48.Eventy
{
    internal class TestowyEventCZtery
    {
        public event ClickEventHandler Click;

        public void SimulateClick()
        {
            Console.WriteLine("Przycisk został kliknięty.");
            OnClick();
        }

        public virtual void OnClick()
        {
            if(Click != null)
            {
                EventArgs eventArgs = new EventArgs();
                Click(this, eventArgs);
            }
        }


        public void ButtonClickHandler(Object sender, EventArgs e)
        {
            Console.WriteLine("Zdarzenie kliknięcia przycisku zostało obsłużone");
        }

        //public static void Main()
        //{
        //    TestowyEventCZtery testowyEventCZtery  = new TestowyEventCZtery();
        //    testowyEventCZtery.Click += testowyEventCZtery.ButtonClickHandler;

        //    testowyEventCZtery.SimulateClick();
        //    Console.ReadLine();
        //}

    }
}
