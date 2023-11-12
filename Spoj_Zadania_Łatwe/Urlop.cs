using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp48
{
    public class Urlop
    {
        private static Dictionary<string, int> dniTygodnia = new Dictionary<string, int>()
        {
            { "poniedzialek", 0 },
            { "wtorek", 1 },
            { "sroda", 2 },
            { "czwartek", 3 },
            { "piatek", 4 },
            { "sobota", 5 },
            { "niedziela", 6 }
        };

        private static Dictionary<string, int> iloscDniWDanymMiesiacu = new Dictionary<string, int>()
        {
            { "styczen", 31 },
            { "luty", 28 },
            { "marzec", 31 },
            { "kwiecien", 30 },
            { "maj", 31 },
            { "czerwiec", 30 },
            { "lipiec", 31 },
            { "sierpien", 31 },
            { "wrzesien", 30 },
            { "pazdziernik", 31 },
            { "listopad", 30 },
            { "grudzien", 31 }
        };

        //public static void Main(string[] args)
        //{
        //    Urlop urlop = new Urlop();
        //    Tuple<int, string, Dictionary<string, List<int>>> zasilanieDanych = urlop.ZasilanieDanymi();
        //    int najdluzszyUrlop = urlop.Miesiace(zasilanieDanych);
        //    Console.WriteLine(najdluzszyUrlop);
        //}

        public Tuple<int, string, Dictionary<string, List<int>>> ZasilanieDanymi()
        {
            string wprowadzeniePierwszaLinijka = Console.ReadLine();
            string[] WprowadzeniePierwszejLinijkiDwa = wprowadzeniePierwszaLinijka.Split(' ');

            int n = int.Parse(WprowadzeniePierwszejLinijkiDwa[0]);
            string d = WprowadzeniePierwszejLinijkiDwa[1];

            int liczbaMiesiecy = int.Parse(Console.ReadLine());

            Dictionary<string, List<int>> dniWolneWMiesiacach = new Dictionary<string, List<int>>();

            for (int i = 0; i < liczbaMiesiecy; i++)
            {
                string miesiacOrazKonkretneDni = Console.ReadLine();
                string[] miesiacOrazKonkretneDniDwa = miesiacOrazKonkretneDni.Split(' ');

                string miesiac = miesiacOrazKonkretneDniDwa[0];
                int dniWolne = int.Parse(miesiacOrazKonkretneDniDwa[1]);

                List<int> dniWolneLista = new List<int>();
                for (int j = 0; j < dniWolne; j++)
                {
                    
                    dniWolneLista.Add(int.Parse(miesiacOrazKonkretneDniDwa[j + 2]));
                }
                dniWolneWMiesiacach.Add(miesiac, dniWolneLista);
            }

            return Tuple.Create(n, d, dniWolneWMiesiacach);
        }

        public int Miesiace(Tuple<int, string, Dictionary<string, List<int>>> zasilanie)
        {
            int[] miesiac30Dni = Enumerable.Range(1, 30).ToArray();
            int[] miesiac31Dni = Enumerable.Range(1, 31).ToArray();
            int[] miesiac28Dni = Enumerable.Range(1, 28).ToArray();

            int dniUrlopu = zasilanie.Item1;
            string preferowanyMiesiac = zasilanie.Item2;
            Dictionary<string, List<int>> dniWolneWMiesiacach = zasilanie.Item3;

            int preferowanyMiesiacDniWolne = dniWolneWMiesiacach.ContainsKey(preferowanyMiesiac) ? dniWolneWMiesiacach[preferowanyMiesiac].Count : 0;

            int najdluzszyUrlop = 0;

            // Sprawdzenie, czy preferowany miesiąc jest już zawarty w dniWolneWMiesiacach
            if (dniWolneWMiesiacach.ContainsKey(preferowanyMiesiac))
            {
                int[] dniWolneWMiesiacu = dniWolneWMiesiacach[preferowanyMiesiac].ToArray();
                Array.Sort(dniWolneWMiesiacu);

                for (int dlugoscUrlopu = 1; dlugoscUrlopu <= dniUrlopu; dlugoscUrlopu++)
                {
                    int indeksDniaTygodnia = dniTygodnia[preferowanyMiesiac];

                    for (int dzien = 1; dzien <= iloscDniWDanymMiesiacu[preferowanyMiesiac]; dzien++)
                    {
                        if (dzien + dlugoscUrlopu > iloscDniWDanymMiesiacu[preferowanyMiesiac])
                        {
                            // Jeśli próbujemy wyjść poza koniec miesiąca, przerwij pętlę
                            break;
                        }

                        if (dzien == 1 || indeksDniaTygodnia == 5 || indeksDniaTygodnia == 6)
                        {
                            // Jeśli pierwszy dzień urlopu, sobota lub niedziela, to sprawdź czy wszystkie dni urlopu są wolne
                            bool wszystkieDniWolne = true;
                            for (int i = 0; i < dlugoscUrlopu; i++)
                            {
                                int dzienSprawdzany = dzien + i;
                                if (dniWolneWMiesiacach.ContainsKey(preferowanyMiesiac) &&
                                    dniWolneWMiesiacach[preferowanyMiesiac].Contains(dzienSprawdzany))
                                {
                                    continue; // Dzień jest wolny, sprawdź następny
                                }
                                else
                                {
                                    wszystkieDniWolne = false;
                                    break;
                                }
                            }

                            if (wszystkieDniWolne)
                            {
                                // Znaleziono najdłuższy ciąg wolnych dni
                                najdluzszyUrlop = dlugoscUrlopu;
                                break;
                            }
                        }

                        // Przesuń się do następnego dnia tygodnia
                        indeksDniaTygodnia = (indeksDniaTygodnia + 1) % 7;
                    }
                }
            }

            // Sprawdź pozostałe miesiące
            foreach (var miesiac in dniWolneWMiesiacach.Keys)
            {
                if (miesiac != preferowanyMiesiac)
                {
                    if (dniWolneWMiesiacach.ContainsKey(miesiac))
                    {
                        int[] dniWolneWMiesiacu = dniWolneWMiesiacach[miesiac].ToArray();
                        Array.Sort(dniWolneWMiesiacu);

                        for (int dlugoscUrlopu = 1; dlugoscUrlopu <= dniUrlopu; dlugoscUrlopu++)
                        {
                            int indeksDniaTygodniaMiesiac = dniTygodnia[miesiac];

                            for (int dzien = 1; dzien <= iloscDniWDanymMiesiacu[miesiac]; dzien++)
                            {
                                if (dzien + dlugoscUrlopu > iloscDniWDanymMiesiacu[miesiac])
                                {
                                    // Jeśli próbujemy wyjść poza koniec miesiąca, przerwij pętlę
                                    break;
                                }

                                if (dzien == 1 || indeksDniaTygodniaMiesiac == 5 || indeksDniaTygodniaMiesiac == 6)
                                {
                                    // Jeśli pierwszy dzień urlopu, sobota lub niedziela, to sprawdź czy wszystkie dni urlopu są wolne
                                    bool wszystkieDniWolne = true;
                                    for (int i = 0; i < dlugoscUrlopu; i++)
                                    {
                                        int dzienSprawdzany = dzien + i;
                                        if (dniWolneWMiesiacach.ContainsKey(miesiac) &&
                                            dniWolneWMiesiacach[miesiac].Contains(dzienSprawdzany))
                                        {
                                            continue; // Dzień jest wolny, sprawdź następny
                                        }
                                        else
                                        {
                                            wszystkieDniWolne = false;
                                            break;
                                        }
                                    }

                                    if (wszystkieDniWolne)
                                    {
                                        // Znaleziono najdłuższy ciąg wolnych dni
                                        najdluzszyUrlop = Math.Max(najdluzszyUrlop, dlugoscUrlopu);
                                        break;
                                    }
                                }

                                // Przesuń się do następnego dnia tygodnia
                                indeksDniaTygodniaMiesiac = (indeksDniaTygodniaMiesiac + 1) % 7;
                            }
                        }
                    }
                }
            }

            return najdluzszyUrlop;
        }
    }
}
