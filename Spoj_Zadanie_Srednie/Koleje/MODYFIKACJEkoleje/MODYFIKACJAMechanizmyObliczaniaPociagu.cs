using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp48.Spoj_Zadanie_Srednie.Koleje.MODYFIKACJEkoleje
{
    internal class MODYFIKACJAMechanizmyObliczaniaPociagu : IPociag
    {
        private int[,] train; // Tablica reprezentująca pociąg
        private int m; // Liczba miejsc w pociągu

        public List<Tuple<int, int, int>> WprowadzoneWartosci { get; set; }

        public int[,] Train
        {
            get 
            {
                return train;
            }
            set
            {
                train = value;
            }
        }
        public int M
        {
            get
            {
                return m;
            }
            set
            {
                m= value;
            }
        }
        public MODYFIKACJAMechanizmyObliczaniaPociagu(int n, int m)
        {
            train = new int[n,m];
            this.m = m;
        }

        public void GlowneObliczenie()
        {
            foreach (var zgloszenie in WprowadzoneWartosci)
            {
                int p = zgloszenie.Item1;
                int k = zgloszenie.Item2;
                int l = zgloszenie.Item3;

                // Sprawdź czy obiekt implementuje interfejs IPociag (operator 'is')
                if (this is IPociag)
                {
                    // Rzutuj na interfejs IPociag (operator 'as')
                    IPociag pociag = this as IPociag;

                    // Wywołaj metodę interfejsu
                    pociag.PrzyjmijPasazerow(p, k, l);
                }

                // Sprawdź czy można zaakceptować zgłoszenie
                bool canAccept = true;
                for (int i = p - 1; i < k; i++)
                {
                    if (train[i,i] + l > m)
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
                        for (int j = p - 1; j < k;j++)
                        {
                            train[i, i] += l;
                        }
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

        // Implementacja metody z interfejsu IPociag
        public void PrzyjmijPasazerow(int poczatek, int koniec, int liczbaPasazerow)
        {
            // Logika przyjmowania pasażerów
            Console.WriteLine($"Przyjęto {liczbaPasazerow} pasażerów od {poczatek} do {koniec}");
        }
    }
}
