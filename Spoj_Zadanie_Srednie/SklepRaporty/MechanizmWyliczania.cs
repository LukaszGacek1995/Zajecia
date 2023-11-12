using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp48.Spoj_Zadanie_Srednie.SklepRaporty
{
    public class MechanizmWyliczania :IObliczanie
    {
        private List<Tuple<int, int>> wartosci { get; set; }

        public MechanizmWyliczania(List<Tuple<int, int>> wartosci)
        {
            this.wartosci = wartosci;
        }

        public Dictionary<int, int> Obliczenia()
        {
            Dictionary<int, int> przechowanieObliczonychWartosci = new Dictionary<int, int>();

            foreach (var tupla in wartosci)
            {
                int numerProduktu = tupla.Item1;
                int ilosc = tupla.Item2;

                if (przechowanieObliczonychWartosci.ContainsKey(numerProduktu))
                {
                    przechowanieObliczonychWartosci[numerProduktu] += ilosc;
                }
                else
                {
                    przechowanieObliczonychWartosci[numerProduktu] = ilosc;
                }
            }

            return przechowanieObliczonychWartosci;
        }
    }
}
