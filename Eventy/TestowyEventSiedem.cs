using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp48.Eventy
{
    internal class TestowyEventSiedem
    {
        public event EventHandler<ButtonClickEventArgts> Clicked;

        public void Click()
        {
            Console.WriteLine("Przycisk zostal klikniety");
            Clicked?.Invoke(this, new ButtonClickEventArgts(DateTime.Now));
           
        }
    }

    internal class ButtonClickEventArgts : EventArgs
    {
        public DateTime ClickTime { get; }

        public ButtonClickEventArgts(DateTime clickTime )
        {
            ClickTime = clickTime;
        }
    }

    internal class ProgramProgram
    {

        //public static void Main()
        // {
        //    TestowyEventSiedem testowyEventSiedem  = new TestowyEventSiedem();
        //    testowyEventSiedem.Clicked += (sender, e) =>
        //    {
        //        Console.WriteLine($"Przycisk klikniety o {e.ClickTime}");
        //    };

        //    testowyEventSiedem.Click();


        //}
    }
}
