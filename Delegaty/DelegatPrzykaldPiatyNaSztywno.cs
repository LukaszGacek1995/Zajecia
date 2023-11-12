using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp48.Delegaty
{
    public delegate void MojDelegacik(int liczbba);
    public class DelegatPrzykaldPiatyNaSztywno
    {
        
        //public static void Main(string[]args)
        //{
        //    DelegatPrzykaldPiatyNaSztywno instancja = new DelegatPrzykaldPiatyNaSztywno();
        //    MojDelegacik deli = new MojDelegacik(instancja.Wyswietl);
        //    deli(32);
        //}

        public void  Wyswietl(int liczba)
        {
            Console.WriteLine("{0} to jest to", liczba);
        }
    }
}
