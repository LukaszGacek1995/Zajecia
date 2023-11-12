using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp48.Spoj_Zadanie_Srednie
{
    public class NAMES_Imiona
    {


        //private static void Main()
        //{
        //    NAMES_Imiona nAMES_Imiona = new NAMES_Imiona();

        //    int liczbaUczniow = int.Parse(Console.ReadLine());
        //    Dictionary<int, string> e = nAMES_Imiona.WprowadzanieDanuych(liczbaUczniow);
        //    nAMES_Imiona.MechanizmDzialania(e);

        //}

        private Dictionary<int, string> WprowadzanieDanuych(int liczbaUczestnikow)
        {
            Dictionary<int, string> dictWartosci = new Dictionary<int, string>();
           

            for (int i = 0; i <= liczbaUczestnikow; i++)
            {
                string[] daneTabString = Console.ReadLine().Split(' ');
                dictWartosci.Add(i, Console.ReadLine());
            }

            return dictWartosci;
        }

        private void MechanizmDzialania(Dictionary<int, string> dictWartosci)
        {
            StringComparer komparer = StringComparer.OrdinalIgnoreCase;
            Dictionary<string, int> pojedynczeImiona = new Dictionary<string, int>();

            int count = 0;
            foreach (var slownikIteracja in dictWartosci)
            {
                string imie = slownikIteracja.Value;
                if (dictWartosci.Equals(imie))
                {
                    pojedynczeImiona[imie]++;
                }
                else
                {
                    pojedynczeImiona.Add(imie, 1);
                }
            }
            WywolanieDanych(pojedynczeImiona);
        }

        private void WywolanieDanych(Dictionary<string, int> pojedynczeImiona)
        {
            foreach (var para in pojedynczeImiona)
            {
                Console.Write($"{pojedynczeImiona.Keys}+'  '+{pojedynczeImiona.Values}");
            }
        }
    }
}
