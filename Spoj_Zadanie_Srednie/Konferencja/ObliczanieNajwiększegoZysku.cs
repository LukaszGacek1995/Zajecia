using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp48.Spoj_Zadanie_Srednie.Konferencja
{
    public class ObliczanieNajwiększegoZysku
    {
        public KlasaObliczajacaDzialanie KlasaObliczajacaDzialanie;
        public WprowadzanieDanychKonferencja wprowadzanieDanychKonferencja;

        public ObliczanieNajwiększegoZysku(WprowadzanieDanychKonferencja wprowadzanieDanychKonferencja, KlasaObliczajacaDzialanie klasaObliczajacaDzialanie)
        {
            this.KlasaObliczajacaDzialanie = klasaObliczajacaDzialanie;
            this.wprowadzanieDanychKonferencja = wprowadzanieDanychKonferencja;
        }

        public int Wynik()
        {
            List<int> mlks = wprowadzanieDanychKonferencja.PrzekazanieWartosciDoKlasyKtoraBedzieObliczala();
            int liczbaPrezentacji = mlks[0];
            int liczbaRezerwacji = mlks[1];
            int wielkoscSali = mlks[2];
            int kosztWynajmuSali = mlks[3];

            // Obliczenie liczby sal potrzebnych do przeprowadzenia prezentacji
            int liczbaSal = (liczbaPrezentacji + (liczbaRezerwacji / wielkoscSali));

            // Zaokrąglenie liczby sal w górę
            int liczbaSalZaokraglona = (int)Math.Ceiling((double)liczbaSal);

            // Obliczenie kosztu wynajmu sali
            int kosztWynajmu = liczbaSalZaokraglona * kosztWynajmuSali;

            // Obliczenie dochodu ze sprzedaży biletów (ceny biletów za każdą prezentację)
            Console.WriteLine("Wprowadź ceny biletów dla każdej prezentacji:");
            string[] cenyBiletowString = Console.ReadLine().Split(' ');
            int[] cenyBiletow = new int[cenyBiletowString.Length];
            for (int i = 0; i < cenyBiletowString.Length; i++)
            {
                cenyBiletow[i] = int.Parse(cenyBiletowString[i]);
            }

            int dochodZeSprzedazy = 0;
            for (int i = 0; i < Math.Min(cenyBiletow.Length, liczbaPrezentacji); i++)
            {
                dochodZeSprzedazy += cenyBiletow[i];
            }

            // Obliczenie zysku dla konferencji
            int zysk = dochodZeSprzedazy - kosztWynajmu;

            Console.WriteLine("Zysk konferencji: " + zysk);
            return zysk;
        }
    }
}