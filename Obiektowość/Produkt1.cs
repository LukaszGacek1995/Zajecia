using ConsoleApp48.Obiektowość.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp48.Obiektowość
{
    public class Produkt
    {
        private string nazwa;
        private decimal cena;
        private string opis;

        public Produkt(string nazwa, decimal cena, string opis)
        {
            this.nazwa = nazwa;
            this.cena = cena;
            this.opis = opis;
        }

        public string Nazwa { get { return nazwa; } }
        public decimal Cena { get { return cena; } }
        public string Opis { get { return opis; } }

        public override string ToString()
        {
            return $"{nazwa} - {cena:C}";
        }
    }

    // Klasa reprezentująca koszyk
    public class Koszyk
    {
        private List<Produkt> produkty;
                                                                                              
        public Koszyk()
        {
            produkty = new List<Produkt>();
        }

        public void DodajProdukt(Produkt produkt)
        {
            produkty.Add(produkt);
        }

        public decimal ObliczCalkowitaWartosc()
        {
            decimal suma = 0;
            foreach (var produkt in produkty)
            {
                suma += produkt.Cena;
            }
            return suma;
        }
    }

    // Klasa reprezentująca zamówienie
    public class Zamowienie : IZamowienie
    {
        private Produkt produkt;
        private int ilosc;

        public Zamowienie(Produkt produkt, int ilosc)
        {
            this.produkt = produkt;
            this.ilosc = ilosc;
        }

        public decimal ObliczCeneZamowienia()
        {
            return produkt.Cena * ilosc;
        }

        public string InformacjeOZamowieniu()
        {
            return $"{produkt.Nazwa}, Ilość: {ilosc}, Całkowita cena: {ObliczCeneZamowienia():C}";
        }
    }

    // Interfejs reprezentujący zamówienie
    public interface IZamowienie
    {
        decimal ObliczCeneZamowienia();
        string InformacjeOZamowieniu();
    }

    public class Program
    {
        //public static void Main(string[] args)
        //{
        //    // Tworzenie produktów
        //    Produkt produkt1 = new Produkt("Laptop", 2500, "Dell XPS 13");
        //    Produkt produkt2 = new Produkt("Smartfon", 1500, "Samsung Galaxy S20");
        //    Produkt produkt3 = new Produkt("Klawiatura", 200, "Logitech G Pro X");

        //    // Tworzenie koszyka
        //    Koszyk koszyk = new Koszyk();
        //    koszyk.DodajProdukt(produkt1);
        //    koszyk.DodajProdukt(produkt2);
        //    koszyk.DodajProdukt(produkt3);

        //    // Wyświetlenie produktów w koszyku
        //    Console.WriteLine("Produkty w koszyku:");
        //    foreach (var produkt in koszyk.Produkty)
        //    {
        //        Console.WriteLine(produkt);
        //    }

        //    // Obliczenie całkowitej wartości zamówienia
        //    decimal calkowitaWartosc = koszyk.ObliczCalkowitaWartosc();
        //    Console.WriteLine($"Całkowita wartość zamówienia: {calkowitaWartosc:C}");

        //    // Składanie zamówienia
        //    Console.WriteLine("\nSkładanie zamówienia:");
        //    Zamowienie zamowienie1 = new Zamowienie(produkt1, 2);
        //    Zamowienie zamowienie2 = new Zamowienie(produkt2, 1);

        //    Console.WriteLine(zamowienie1.InformacjeOZamowieniu());
        //    Console.WriteLine(zamowienie2.InformacjeOZamowieniu());
        //}
    }

}
