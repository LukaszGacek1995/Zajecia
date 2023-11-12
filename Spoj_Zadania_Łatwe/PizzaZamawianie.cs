using System;
using System.Text;

namespace ConsoleApp48
{
    internal class PizzaZamawianie
    {
        //public static void Main(string[] args)
        //{
        //    PizzaZamawianie pizza = new PizzaZamawianie();
        //    int t = int.Parse(Console.ReadLine());

        //    Tuple<int, int[][]> metodaPierwsza = pizza.UzupelnianieDanych(t);

        //    string mechanizmPorownywania = pizza.MechanizmPorownywania(metodaPierwsza.Item2);

        //    Console.WriteLine(mechanizmPorownywania);

        //    Console.ReadKey();
        //}

        private Tuple<int, int[][]> UzupelnianieDanych(int t)
        {
            if (t >= 101)
            {
                throw new Exception("Przekroczono zakres");
            }

            int[][] tablicaCzterechWejsciowych = new int[t][];
            for (int i = 0; i < t; i++)
            {
                int[] czteryWejsciowe = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

                int Nm = czteryWejsciowe[0];
                int Sm = czteryWejsciowe[1];
                int Ng = czteryWejsciowe[2];
                int Sg = czteryWejsciowe[3];

                tablicaCzterechWejsciowych[i] = czteryWejsciowe;
            }
            return Tuple.Create(t, tablicaCzterechWejsciowych);
        }

        private string MechanizmPorownywania(int[][] dane)
        {
            StringBuilder sb = new StringBuilder();
            foreach (int[] wiersz in dane)
            {
                int pierwszaWartosc = wiersz[0];
                int drugaWartosc = wiersz[1];
                int trzeciaWartosc = wiersz[2];
                int czwartaWartosc = wiersz[3];



                int dzialaniePierwsze = pierwszaWartosc * drugaWartosc;
                int dzialanieDrugie = trzeciaWartosc * czwartaWartosc;

                if (dzialaniePierwsze > dzialanieDrugie)
                {
                    sb.AppendLine("Mateusz");
                }
                else
                {
                    sb.AppendLine("Grzesiek");
                }
                if (dzialaniePierwsze == dzialanieDrugie)
                {
                    sb.AppendLine("Porcje są takie same");
                }
            }
            return sb.ToString();
        }
    }
}

