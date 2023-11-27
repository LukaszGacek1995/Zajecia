using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ConsoleApp48.Spoj_Zadanie_Srednie.Światelka.ModyfikacjeZadania.MODWartosciWprowadzone;

namespace ConsoleApp48.Spoj_Zadanie_Srednie.Światelka.ModyfikacjeZadania
{
    public class MODObliczanieTakNie
    {
        public static void Main()
        {
            MODWartosciWprowadzone wartosciWprowadzone = new MODWartosciWprowadzone();
            List<MODWartosciWprowadzone.TestInput> daneWejsciowe = wartosciWprowadzone.WartosciWprowadzaoneDalej();

            List<MODIDataInput> daneWejscioweConverted = daneWejsciowe.Select(input => new MODIDataInput(input)).ToList();

            MODSprawdzanieSwiatelek sprawdzanieSwiatelek = new MODSprawdzanieSwiatelek(daneWejscioweConverted);
            var wypisanieTakNie = sprawdzanieSwiatelek.StringDlaSwitchCase();

            foreach (var wypisanie in wypisanieTakNie)
            {
                Console.WriteLine(wypisanie);
            }
            Console.ReadKey();
        }
    }
}
