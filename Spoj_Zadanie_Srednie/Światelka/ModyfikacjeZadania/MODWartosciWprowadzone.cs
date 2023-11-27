using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp48.Spoj_Zadanie_Srednie.Światelka.ModyfikacjeZadania
{
    public class MODWartosciWprowadzone
    {
        public class TestInput
        {
            public int n { get; set; }
            public int m { get; set; }
            public List<Tuple<int, int>> polaczenia { get; set; }
        }

        public List<TestInput> WartosciWprowadzaoneDalej()
        {
            int iloscZestawow = int.Parse(Console.ReadLine());
            List<TestInput> wyniki = new List<TestInput>();

            for (int zestaw = 0; zestaw < iloscZestawow; zestaw++)
            {
                List<string> wartosci = null;

                // tutaj doaje m oraz n
                while (wartosci == null || wartosci.Count != 2)
                {
                    Console.WriteLine("Wprowadź dwie liczby oddzielone spacją:");
                    wartosci = Console.ReadLine().Split(' ').ToList();

                    if (wartosci.Count != 2)
                    {
                        Console.WriteLine("Wprowadziłeś nieprawidłową liczbę wartości. Spróbuj ponownie.");
                    }
                }

                int n, m;

                // Tutaj deklaruje wartosci d m oraz n
                if (int.TryParse(wartosci[0], out n) && int.TryParse(wartosci[1], out m))
                {
                    List<Tuple<int, int>> polaczenia = new List<Tuple<int, int>>();

                    for (int i = 0; i < m; i++)
                    {
                        List<string> wartosciKolejne = null;

                        while (wartosciKolejne == null || wartosciKolejne.Count != 2)
                        {
                            wartosciKolejne = Console.ReadLine().Split(' ').ToList();

                            if (wartosciKolejne.Count != 2)
                            {
                                Console.WriteLine("Wprowadziłeś nieprawidłową parę liczb. Spróbuj ponownie.");
                            }
                        }

                        int eloN, eloM;

                        if (int.TryParse(wartosciKolejne[0], out eloN) && int.TryParse(wartosciKolejne[1], out eloM))
                        {
                            polaczenia.Add(new Tuple<int, int>(eloN, eloM));
                        }
                        else
                        {
                            Console.WriteLine("Wprowadzone zostały nieprawidłowe dane liczbowe");
                            i--;
                        }
                    }

                    wyniki.Add(new TestInput { n = n, m = m, polaczenia = polaczenia });
                }
                else
                {
                    Console.WriteLine("Wprowadziłeś nieprawidłowe liczby n lub m. Spróbuj ponownie.");
                    zestaw--;
                }
                Console.WriteLine("        ");
            }

            return wyniki;
        }
    }
}
