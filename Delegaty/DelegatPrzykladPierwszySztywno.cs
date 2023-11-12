using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{

    delegate void DelegatWywolanie(string message);
    class Program
    {
        //static void Main()
        //{

        //    DelegatWywolanie del = new DelegatWywolanie(ShowMessageUpperCase);

        //    del("eloooo");

        //    DelegatWywolanie delDell = new DelegatWywolanie(ShowMessage);
        //    delDell(" Konskwercja to podstawa ");

        //    Console.ReadKey();
        //}
        static void ShowMessage(string message)
        {
            Console.WriteLine("Komunikat: " + message);
        }

        static void ShowMessageUpperCase(string message)
        {
            Console.WriteLine("KOMUNIKAT: " + message.ToUpper());
        }
    }
}
