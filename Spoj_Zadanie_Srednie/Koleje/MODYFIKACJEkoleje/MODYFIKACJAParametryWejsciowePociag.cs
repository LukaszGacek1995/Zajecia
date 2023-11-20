using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp48.Spoj_Zadanie_Srednie.Koleje.MODYFIKACJEkoleje
{
    internal class MODYFIKACJAParametryWejsciowePociag
    {

        public int LiczbaMiast_N { get; private set; }
        public int LiczbaMiejsceWPociagu_M { get; private set; }
        public int LiczbaZgloszen_Z { get; private set; }
        public List<Tuple<int, int, int>> WprowadzoneWartosci { get; private set; }

        public void WprowadzeniePoczatkowychWartosci(out int n, out int m, out int z, out List<Tuple<int, int, int>> zgloszenia)
        {
            

            n = m = z = 0;
            string[] trzyWartosciWStringu;
            bool poprawneTrzyWartosci = false;

            

            while (!poprawneTrzyWartosci)
            {
                trzyWartosciWStringu = Console.ReadLine().Split(' ');

                if (trzyWartosciWStringu.Length == 3)
                {
                    poprawneTrzyWartosci = true;

                    // Wywałanie enumów zamiast pojedyńczych cyfr
                    //n = int.Parse(trzyWartosciWStringu?[(int)EnumClass.Parametry.LiczbaMiast] ?? "0");
                    n = trzyWartosciWStringu.Length;
                    m = int.Parse(trzyWartosciWStringu?[(int)EnumClass.Parametry.LiczbaMiejscWPociagu] ?? "0");
                    z = int.Parse(trzyWartosciWStringu?[(int)EnumClass.Parametry.LiczbaZgloszen] ?? "0");
                }
                else
                {

                    Console.WriteLine("Wprowadziłeś wartośći z poza kresu, muszą być dokładnie 3 cyfry");
                    Console.WriteLine($"Wprowadzona przez Ciebie ilość to {trzyWartosciWStringu?.Length ?? 0}, spróbuj jeszcze raz");
                }
            }

            zgloszenia = new List<Tuple<int, int, int>>();
            for (int i = 0; i < LiczbaZgloszen_Z; i++)
            {
                trzyWartosciWStringu = Console.ReadLine().Split(' ');
                int p = int.Parse(trzyWartosciWStringu?[0] ?? "0");
                int k = int.Parse(trzyWartosciWStringu?[1]?? "0");
                int l = int.Parse(trzyWartosciWStringu?[2] ?? "0");
                WprowadzoneWartosci?.Add(new Tuple<int, int, int>(p, k, l));
            }
        }
    }
}
