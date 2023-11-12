using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp48.Spoj_Zadanie_Srednie.ŁamaczGG
{
    public class Łamacz_gg
    {
        //public static void Main()
        //{

        //    Console.WriteLine("Wprowadź hasła poniżej:");

        //    List<string> lista = WprowadzDane();

        //    LamaczGGMechanizmDzialania lamaczGGMechanizmDzialania = new LamaczGGMechanizmDzialania();

        //    List<string> lamcz = lamaczGGMechanizmDzialania.Lamacz(lista);

        //    foreach (string odkodowaneHaslo in lamcz)
        //    {
        //        Console.WriteLine(odkodowaneHaslo);
        //    }
        //}

        public static List<string> WprowadzDane()
        {
            List<string> lista = new List<string>();

            int iloscHasel;

            do
            {
                Console.WriteLine("Wprowadź ilość haseł:");
            }
            while (!int.TryParse(Console.ReadLine(), out iloscHasel));


            string dozwoloneLitery = "ABCDEFGHIJKLMNOP";
            string nieDozwoloneLitery = "QRSTUVEXYZ";


            for (int i = 0; i < iloscHasel; i++)
            {
                Console.WriteLine($"Wprowadz haslo{i + 1}");


                string haslo = Console.ReadLine();

                if (haslo.Length != 20)
                {
                    Console.WriteLine("Wprowadzone haslo nie ma dokładnie 20 liter");
                    continue;
                }
                bool poprawneHaslo = true;
                foreach (char litera in haslo)
                {
                    if (!dozwoloneLitery.Contains(litera))
                    {
                        Console.WriteLine($"Niepoprawna litera:{litera} ");
                        poprawneHaslo = false;
                        break;
                    }
                }
                if (poprawneHaslo)
                {
                    lista.Add(haslo);
                }
            }
            return lista;
        }
    }
}
