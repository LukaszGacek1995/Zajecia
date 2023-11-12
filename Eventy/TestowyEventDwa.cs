using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

public delegate void DelegatDeletage();

namespace ConsoleApp48.Eventy
{
    public class Button
    {
        // Krok 1: Definicja delegata
        public delegate void ClickHandler();

        // Krok 2: Definicja eventu przy użyciu delegata
        public event ClickHandler Click;

        // Krok 5: Metoda do wywołania zdarzenia
        protected virtual void OnClick()
        {
            Click?.Invoke();
        }

        public void SimulateClick()
        {
            Console.WriteLine("Button clicked.");
            // Krok 5: Wywołanie zdarzenia
            OnClick();
        }
    }

    public class Programme
    {
        // Krok 3: Metoda obsługi (handler)
        public static void HandleClick()
        {
            Console.WriteLine("Button was handled.");
        }

        //public static void Main(string[] args)
        //{
        //    Button button = new Button();

        //    // Krok 4: Subskrypcja eventu przez metodę obsługi
        //    button.Click += HandleClick;

        //    button.SimulateClick(); // Wywołuje obsługę eventu
        //}
    }
}
