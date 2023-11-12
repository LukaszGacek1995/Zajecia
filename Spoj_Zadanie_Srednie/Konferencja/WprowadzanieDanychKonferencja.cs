using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp48.Spoj_Zadanie_Srednie.Konferencja
{
    public class WprowadzanieDanychKonferencja : IPrzekazywanie
    {
        int m; // liczba przeprowadzonych prezentacji
        int l; // liczba rezerwacji
        int k; // wielkość każdej sali
        int s; // koszt wynajęcia sali

        public delegate bool ValidationDelegate(int value);

        public WprowadzanieDanychKonferencja(int M, int L, int K, int S)
        {
            this.m = M;
            this.l = L;
            this.k = K;
            this.s = S;
        }

        public int ValidationInput(int value, ValidationDelegate validationDelegate, string fieldName)
        {
            while (!validationDelegate(value))
            {
                Console.WriteLine($"Błąd! wprowadź poprawna wartość dla {fieldName}");
                value = int.Parse(Console.ReadLine());
            }
            return value;
        }

        public int PobierzCzwartylementy()
        {
            return s;
        }

        private bool CheckRange(int value)
        {
            return value >= 1 && value <= 1000;
        }

        public int PobierxDrugielement()
        {
            return l;
        }

        public List<int> PrzekazanieWartosciDoKlasyKtoraBedzieObliczala()
        {
            List<int> ints = new List<int>
            {
                m, l, k, s
            };

            return ints;
        }
    }
}

