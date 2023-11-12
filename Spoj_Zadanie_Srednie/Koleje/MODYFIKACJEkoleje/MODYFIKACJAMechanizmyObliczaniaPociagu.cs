using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp48.Spoj_Zadanie_Srednie.Koleje.MODYFIKACJEkoleje
{
    internal class MODYFIKACJAMechanizmyObliczaniaPociagu
    {
        private int[] train; // Tablica reprezentująca pociąg
        private int m; // Liczba miejsc w pociągu

        public List<Tuple<int, int, int>> WprowadzoneWartosci { get; set; }

        public MODYFIKACJAMechanizmyObliczaniaPociagu(int n, int m)
        {
            train = new int[n];
            this.m = m;
        }

        public void GlowneObliczenie()
        {
            foreach (var zgloszenie in WprowadzoneWartosci)
            {
                int p = zgloszenie.Item1;
                int k = zgloszenie.Item2;
                int l = zgloszenie.Item3;

                bool canAccept = true;
                // Sprawdź czy można zaakceptować zgłoszenie
                for (int i = p - 1; i < k; i++)
                {
                    if (train[i] + l > m)
                    {
                        canAccept = false;
                        break;
                    }
                }

                // Jeśli można zaakceptować, zaktualizuj stan miejsc w pociągu
                if (canAccept)

                {
                    for (int i = p - 1; i < k; i++)
                    {
                        train[i] += l;
                    }
                }

                // Dodaj odpowiedni wynik do listy
                ZwrotkaZOdpowiedniaOdp(canAccept);
            }
        }

        private void ZwrotkaZOdpowiedniaOdp(bool canAccept)
        {
            Console.WriteLine(canAccept ? "T" : "N");
        }
    }
}
