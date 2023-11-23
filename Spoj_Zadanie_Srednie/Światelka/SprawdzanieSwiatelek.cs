using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using static ConsoleApp48.Spoj_Zadanie_Srednie.Światelka.WartosciWprowadzone;

namespace ConsoleApp48.Spoj_Zadanie_Srednie.Światelka
{
    public class SprawdzanieSwiatelek
    {
        public List<WartosciWprowadzone.TestInput> daneWejsciowePrzekazane;
        public SprawdzanieSwiatelek(List<WartosciWprowadzone.TestInput> dane)
        {
            this.daneWejsciowePrzekazane = dane;
        }


        public List<string> StringDlaSwitchCase()
        {
            List<string> listaElementówDoSwitch = SprawdzanieObliczanie();
            List<string> final = new List<string>();
            foreach (var elementySwitch in listaElementówDoSwitch)
            {
                switch(elementySwitch)
                {
                    case "Git":
                    {

                            final.Add("TAK");
                            break;
                    }
                    case "Lipa":
                    {

                            final.Add("NIE");
                            break;
                    }

                }
            }

            return final;
        }

        public List<string> SprawdzanieObliczanie()
        {

            List<string> listaKomentDoSwitchCase = new List<string>();
            foreach (var testInput in daneWejsciowePrzekazane)
            {
                int n = testInput.n;
                int m = testInput.m;
                List<Tuple<int, int>> lacze = testInput.polaczenia;


                if (MechanizmDoIf(lacze))
                {

                    listaKomentDoSwitchCase.Add("Git");

                }
                else
                {
                    listaKomentDoSwitchCase.Add("Lipa");
                }

            }
            return listaKomentDoSwitchCase;
        }


        public bool MechanizmDoIf(List<Tuple<int, int>> lacze)
        {
            Dictionary<int, HashSet<int>> kolory = new Dictionary<int, HashSet<int>>();

            foreach (var polaczenie in lacze)
            {
                int swiatelkoA = polaczenie.Item1;
                int swiatelkoB = polaczenie.Item2;

                if (!kolory.ContainsKey(swiatelkoA))
                {
                    kolory[swiatelkoA] = new HashSet<int>();
                }
                if (!kolory.ContainsKey(swiatelkoB))
                {
                    kolory[swiatelkoB] = new HashSet<int>();
                }

                // Sprawdź, czy swiatelkoA ma już przypisany kolor.
                if (kolory[swiatelkoA].Count < 2)
                {
                    kolory[swiatelkoA].Add(1); // Przypisz pierwszy kolor
                }

                // Sprawdź, czy swiatelkoB ma już przypisany kolor.
                if (kolory[swiatelkoB].Count < 2)
                {
                    // Jeśli swiatelkoB ma ten sam kolor co swiatelkoA, przypisz mu inny kolor.
                    if (kolory[swiatelkoA].Contains(1))
                    {
                        kolory[swiatelkoB].Add(2);
                    }
                    else
                    {
                        kolory[swiatelkoB].Add(1);
                    }
                }
                // Jeśli oba mają już przypisane dwa kolory, zwróć false.
                else if (kolory[swiatelkoA].Count == 2 && kolory[swiatelkoB].Count == 2)
                {
                    return false;
                }
            }

            // Jeśli wszystko przeszło pomyślnie, zwróć true.
            return true;
        }
    }
}
