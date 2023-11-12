using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp48.Delegaty
{
    public delegate void EventHandler2(string message);
    public class DelegatZlozonyKolejnuy
    {
        public event EventHandler2 NazwaEventu;

        public void RiseEvent(string message)
        {
            Console.WriteLine("Event" + message);
            NazwaEventu?.Invoke(message);
        }
    }


    public class EventSubscirber
    {
        private string name;

        public EventSubscirber(string Name)
        {
            this.name = Name;
        }
        public void HandleEvent(string message)
        {
            Console.WriteLine($"{name} przekazuje wiadomosc {message}");
        }
    }


    public class Opalanie
    {
        //public static void Main()
        //{
        //    DelegatZlozonyKolejnuy delegatZlozonyKolejnuy = new DelegatZlozonyKolejnuy();

        //    EventSubscirber eventSubscirber1 = new EventSubscirber("pierwsze imie");
        //    EventSubscirber eventSubscirber2 = new EventSubscirber("drugie imie");

        //    delegatZlozonyKolejnuy.NazwaEventu += eventSubscirber1.HandleEvent;
        //    delegatZlozonyKolejnuy.NazwaEventu += eventSubscirber2.HandleEvent;

        //    delegatZlozonyKolejnuy.RiseEvent("Elo tak");
        //    Console.ReadLine();
        //}
    }
}
