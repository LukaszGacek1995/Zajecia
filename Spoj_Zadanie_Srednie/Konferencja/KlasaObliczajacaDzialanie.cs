using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static ConsoleApp48.Spoj_Zadanie_Srednie.Konferencja.WprowadzanieDanychKonferencja;

namespace ConsoleApp48.Spoj_Zadanie_Srednie.Konferencja
{
    public class KlasaObliczajacaDzialanie
    {
        private WprowadzanieDanychKonferencja wprowadzanieDanychKonferencja;

        public KlasaObliczajacaDzialanie(WprowadzanieDanychKonferencja wprowadzenie)
        {
            this.wprowadzanieDanychKonferencja = wprowadzenie;
            WykonajObliczenia();
        }

        public void WykonajObliczenia()
        {
            WprowadzanieDanychKonferencja wprowadzanieDanychKonferencja = this.wprowadzanieDanychKonferencja;
            int czwartyElementListy = wprowadzanieDanychKonferencja.PobierzCzwartylementy();
            int drugiElementListy = wprowadzanieDanychKonferencja.PobierxDrugielement();
            Dictionary<int, int> dictionary = new Dictionary<int, int>();

            Console.WriteLine("Wprowadź ceny biletów dla każdej prezentacji:");
            string[] cenyPoszczegolnychRezerwacji = Console.ReadLine().Split(' ');
            int[] liczbaCenyPoszczegolnychRezerwacji = new int[cenyPoszczegolnychRezerwacji.Length];
            ValidationDelegate validationDelegate = CheckPrice;

            for (int i = 0; i < cenyPoszczegolnychRezerwacji.Length; i++)
            {
                int price = int.Parse(cenyPoszczegolnychRezerwacji[i]);
                liczbaCenyPoszczegolnychRezerwacji[i] = ValidateInput(price, validationDelegate);
            }

            Console.WriteLine("Wprowadź numer rezerwacji oraz liczbę biletów na nią");
            int liczbaRezerwacji = wprowadzanieDanychKonferencja.PobierxDrugielement();
            for (int j = 1; j <= liczbaRezerwacji; j++)
            {
                string input = Console.ReadLine();
                string[] values = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                if (values.Length == 2 && int.TryParse(values[0], out int key) && int.TryParse(values[1], out int value))
                {
                    dictionary[key] = value;
                }
                else
                {
                    Console.WriteLine("Nieprawidłowy format danych, proszę spróbować ponownie ");
                    j--;
                }
            }
        }

        private int ValidateInput(int value, ValidationDelegate validationDelegate)
        {
            while (!validationDelegate(value))
            {
                Console.WriteLine("Błąd! Wprowadź poprawną cenę biletu:");
                value = int.Parse(Console.ReadLine());
            }
            return value;
        }

        private bool CheckPrice(int value)
        {
            return value >= 1 && value <= 10000;
        }
    }
}