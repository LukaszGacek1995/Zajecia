using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp48.Linq
{
    public class ProsteZadanieLinku2
    {

        //public static void Main()
        //{
        //   string wynik =  UnikatoweWKolejnosciWystepowania();
        //    Console.WriteLine(wynik);
        //}

        public static string  UnikatoweWKolejnosciWystepowania()
        {
            string tekst = "abracadabra";

            var dzialnie = tekst.Where(char.IsLetter)
                                .Distinct()
                                .OrderBy(c => c);
            string laczenie = string.Join("", dzialnie);
            return laczenie;
        }

    }
}
