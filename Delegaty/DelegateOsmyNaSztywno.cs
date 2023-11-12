using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp48.Delegaty
{
    public delegate void PrintDeleagt(string message);
    internal class DelegateOsmyNaSztywno
    {
        public void PrintToConsole(string message)
        {
            Console.WriteLine("wydruk z konsoli" + message);
        }

        public void PrintToLog(string messege)
        {
            Console.WriteLine("zapis z logu" + messege);
        }

        public void ProcessMessage(string message, PrintDeleagt printMethod)
        {
            printMethod(message);
        }

        //public static void Main()
        //{
        //    DelegateOsmyNaSztywno delegateOsmyNaSztywno = new DelegateOsmyNaSztywno();
        //    string message = "Hello  Świecie ";


        //    PrintDeleagt printdelegatPierwszy = new PrintDeleagt(delegateOsmyNaSztywno.PrintToConsole);
        //    delegateOsmyNaSztywno.ProcessMessage(message, printdelegatPierwszy);


        //    PrintDeleagt printDelegatDwa = new PrintDeleagt(delegateOsmyNaSztywno.PrintToLog);
        //    delegateOsmyNaSztywno.ProcessMessage(message, printDelegatDwa);

        //}

    }
}
