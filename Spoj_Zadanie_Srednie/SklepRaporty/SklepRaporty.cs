using ConsoleApp48.Spoj_Zadanie_Srednie.SklepRaporty;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp48.Spoj_Zadanie_Srednie
{
    public class SklepRaportyy
    {
        private List<Tuple<int, int>> NumerProduktuOrazIlosc { get; set; }

        public SklepRaportyy()
        {
            NumerProduktuOrazIlosc = new List<Tuple<int, int>>();
        }

        //public static void Main()
        //{
        //    SklepRaportyy sklepRaporty = new SklepRaportyy();    
        //    WprowadzenieWartosci();
        //    MechanizmWyliczania mechanizmWyliczania = new MechanizmWyliczania(sklepRaporty.NumerProduktuOrazIlosc);

        //    Console.WriteLine("Teraz będzie wprowadzany wynik zadania");
        //    Console.WriteLine(mechanizmWyliczania.Obliczenia().Count);

        //    foreach (var entry in mechanizmWyliczania.Obliczenia())
        //    {
        //        Console.WriteLine($"{entry.Key} {entry.Value}");
        //    }
        //}

        public static List<Tuple<int, int>> WprowadzenieWartosci()
        {
            int wprowadzenieIlosciRaportow = int.Parse(Console.ReadLine());

            List<Tuple<int, int>> NumerProduktuOrazIlosc = new List<Tuple<int, int>>();

            if (wprowadzenieIlosciRaportow >= 1 && wprowadzenieIlosciRaportow <= 1000000)
            {
                Console.WriteLine("Wprowadz wartosci: numer produktu oraz jego ilosc");

                for (int i = 1; i <= wprowadzenieIlosciRaportow; i++)
                {
                    bool poprawneDane = false;

                    do
                    {
                        string[] wprowadzenieDwochWartosci = Console.ReadLine().Split();

                        if (wprowadzenieDwochWartosci.Length == 2)
                        {
                            poprawneDane = true;

                            int numerProduktu = int.Parse(wprowadzenieDwochWartosci[0]);
                            int ilosc = int.Parse(wprowadzenieDwochWartosci[1]);

                            NumerProduktuOrazIlosc.Add(Tuple.Create(numerProduktu, ilosc));
                        }
                        else
                        {
                            Console.WriteLine($"Nie wybrałeś odpowiedniej ilości liczb, twoja ilosc to: {wprowadzenieDwochWartosci.Length}");
                            Console.WriteLine("Spróbuj ponownie. Podaj dwie liczby odzielone spacja");
                        }
                    }
                    while (!poprawneDane);
                }
            }
            else
            {
                Console.WriteLine("Przekroczono zakres, spróbuj wybrać jeszcez raz ");
            }
            return NumerProduktuOrazIlosc;
        }
    }
}

