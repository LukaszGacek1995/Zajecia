using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp48.Delegaty
{
    // Definiowanie złożonego delegata do obsługi zdarzeń
    delegate void EventHandler(string message);

    // Klasa reprezentująca wydawcę (źródło zdarzeń)
    class Publisher
    {
        // Zdarzenie oparte na złożonym delegacie
        public event EventHandler EventOccured;

        // Metoda wywołująca zdarzenie
        public void RaiseEvent(string message)
        {
            EventOccured?.Invoke(message);
        }
    }

    // Klasa reprezentująca subskrybenta (obserwatora)
    class Subscriber
    {
        private string name;

        public Subscriber(string name)
        {
            this.name = name;
        }

        // Metoda obsługująca zdarzenie
        public void HandleEvent(string message)
        {
            Console.WriteLine($"{name} received message: {message}");
        }
    }

    class Program112
    {
        //static void Main(string[] args)
        //{
        //    Publisher publisher = new Publisher();

        //    // Tworzenie subskrybentów
        //    Subscriber subscriber1 = new Subscriber("Subscriber 1");
        //    Subscriber subscriber2 = new Subscriber("Subscriber 2");

        //    // Subskrybowanie zdarzenia przez dodanie metod do delegata
        //    publisher.EventOccured += subscriber1.HandleEvent;
        //    publisher.EventOccured += subscriber2.HandleEvent;

        //    // Wywołanie zdarzenia, co spowoduje wywołanie wszystkich subskrybentów
        //    publisher.RaiseEvent("Hello, subscribers!");

        //    // Usunięcie jednego z subskrybentów
        //    publisher.EventOccured -= subscriber1.HandleEvent;

        //    // Ponowne wywołanie zdarzenia, tylko jeden subskrybent zostanie wywołany
        //    publisher.RaiseEvent("Event after unsubscribing.");

        //    Console.ReadLine();
        //}
    }
}
