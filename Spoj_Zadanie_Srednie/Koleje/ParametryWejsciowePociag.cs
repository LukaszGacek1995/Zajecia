using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp48.Spoj_Zadanie_Srednie.Koleje
{
    internal class ParametryWejsciowePociag
    {
        public int LiczbaMiast_N { get; private set; }
        public int LiczbaMiejsceWPociagu_M { get; private set; }
        public int LiczbaZgloszen_Z { get; private set; }
        public List<Tuple<int, int, int>> WprowadzoneWartosci { get; private set; }
        public void WprowadzeniePoczatkowychWartosci()
        {
            string[] trzyWartosciWStringu;
            bool poprawneTrzyWartosci = false;

            while (!poprawneTrzyWartosci)
            {
                trzyWartosciWStringu = Console.ReadLine().Split(' ');

                if (trzyWartosciWStringu.Length == 3)
                {
                    poprawneTrzyWartosci = true;
                    LiczbaMiast_N = int.Parse(trzyWartosciWStringu[0]);
                    LiczbaMiejsceWPociagu_M = int.Parse(trzyWartosciWStringu[1]);
                    LiczbaZgloszen_Z = int.Parse(trzyWartosciWStringu[2]);
                }
                else
                {
                    Console.WriteLine("Wprowadziłeś wartośći z poza kresu, muszą być dokładnie 3 cyfry");
                    Console.WriteLine($"Wprowadzona przez Ciebie ilość to {trzyWartosciWStringu.Length}, spróbuj jeszcze raz");
                }
            }

            WprowadzoneWartosci = new List<Tuple<int, int, int>>();
            for (int i = 0; i < LiczbaZgloszen_Z; i++)
            {
                trzyWartosciWStringu = Console.ReadLine().Split(' ');
                int p = int.Parse(trzyWartosciWStringu[0]);
                int k = int.Parse(trzyWartosciWStringu[1]);
                int l = int.Parse(trzyWartosciWStringu[2]);
                WprowadzoneWartosci.Add(new Tuple<int, int, int>(p, k, l));
            }
        }
    }
}
