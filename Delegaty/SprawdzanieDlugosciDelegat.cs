using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp48.Delegaty
{
    public delegate bool SprawdzanieDlugosci(string napis, int limit);

    public class SprawdzanieDlugosciDelegat
    {
        //public static void
        //(string[] args)
        //{
        //    // Definicja metody, która będzie używana jako implementacja delegata.
        //    bool SprawdzDlugosc(string napis, int limit)
        //    {
        //        return napis.Length > limit;
        //    }

        //    // Tworzenie instancji delegata i przypisanie mu metody SprawdzDlugosc.
        //    SprawdzanieDlugosci sprawdzanieDlu = new SprawdzanieDlugosci(SprawdzDlugosc);

        //    string naszNapis = "WItaj świecie";
        //    int naszaLiczba = 15;

        //    // Wywołanie delegata.
        //    bool sprawdzanieCzyDlugosc = sprawdzanieDlu(naszNapis, naszaLiczba);

        //    if (sprawdzanieCzyDlugosc)
        //    {
        //        Console.WriteLine("TAK");
        //    }
        //    else
        //    {
        //        Console.WriteLine("NIE");
        //    }
        //}
    }
}
