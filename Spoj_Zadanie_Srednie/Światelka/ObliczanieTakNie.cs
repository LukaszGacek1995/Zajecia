using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ConsoleApp48.Spoj_Zadanie_Srednie.Światelka.WartosciWprowadzone;

namespace ConsoleApp48.Spoj_Zadanie_Srednie.Światelka
{
    internal class ObliczanieTakNie
    {
        public static void Main()
        {
            WartosciWprowadzone wartosciWprowadzone = new WartosciWprowadzone();
            List<TestInput> daneWejsciowe = wartosciWprowadzone.WartosciWprowadzaoneDalej();

            SprawdzanieSwiatelek sprawdzanieSwiatelek = new SprawdzanieSwiatelek(daneWejsciowe);
           var wypisanieTakNie = sprawdzanieSwiatelek.StringDlaSwitchCase();

            foreach(var wypisanie in wypisanieTakNie)
            {
                Console.WriteLine(wypisanie);
            }
            Console.ReadKey();
        }
    }
}
