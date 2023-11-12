using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp48.Delegaty
{
    public delegate void MojDelegat(string message);
    public class DelegatTrzeciPrzykladNaSztywno
    {
        public void Metoda1(string message)
        {
             Console.WriteLine("tekstutatj" + message);
        }

        //public static void Main()
        //{
        //    DelegatTrzeciPrzykladNaSztywno del = new DelegatTrzeciPrzykladNaSztywno();

        //    MojDelegat moj = new MojDelegat(del.Metoda1);
        //    moj("Teks z delegata");
        //}

    }
}
