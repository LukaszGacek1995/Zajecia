using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp48
{
    public class DrużynaSportowa
    {
        //public static void
        //()
        //{
        //    DrużynaSportowa duzyna = new DrużynaSportowa();

        //    Tuple<int, Dictionary<int, string>> wprowadzenieDanych = duzyna.WprowadzenieGraczy();
        //    string mechanimDzialania = duzyna.MechanizmAnalizy(wprowadzenieDanych);
        //    Console.WriteLine(mechanimDzialania);
        //}

        public Tuple<int, Dictionary<int, string>> WprowadzenieGraczy()
        {
            int liczbaGraczy = int.Parse(Console.ReadLine());

            if (liczbaGraczy > 0 && liczbaGraczy < 100)
            {
                Dictionary<int, string> slownikGraczy = new Dictionary<int, string>();

                for (int i = 0; i < liczbaGraczy; i++)
                {
                    string wprowadzenie = Console.ReadLine();
                    string[] tablicatringWprowadzenie = wprowadzenie.Split(' ');

                    if (tablicatringWprowadzenie.Length == 2)
                    {
                        int idGracza = int.Parse(tablicatringWprowadzenie[0]);
                        string imieGracza = tablicatringWprowadzenie[1];

                        slownikGraczy.Add(idGracza, imieGracza);
                    }
                }
                return Tuple.Create(liczbaGraczy, slownikGraczy);
            }
            return null;
        }

        public string MechanizmAnalizy(Tuple<int, Dictionary<int, string>> wartosciPrzekazane)
        {
            int iloscGraczy = wartosciPrzekazane.Item1;
            if(iloscGraczy >=10)
            {
                return string.Format("Gramy, edzie nas: {0}", iloscGraczy);
            }
            else
            {
                return string.Format("Nie gramy, jest nas: {0}", iloscGraczy);
            }
        }
    }

}
