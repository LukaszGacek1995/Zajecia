using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp48.Eventy
{
    class Buttonnn
    {
        public event EventHandler Clicked;

        public void Click()
        {
            Console.WriteLine("Przycisk został kliknięty.");
            Clicked?.Invoke(this, EventArgs.Empty);
        }
    }

    class Programmm
    {
        //static void Main(string[] args)
        //{
        //    Button button = new Button();
        //    button.Clicked += ButtonClicked;

        //    button.Click();

        //    Console.ReadLine();
        //}

        static void ButtonClicked(object sender, EventArgs e)
        {
            Console.WriteLine("Zdarzenie: Przycisk kliknięty!");
        }
    }
}
