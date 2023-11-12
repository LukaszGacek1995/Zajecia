using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp48.Spoj_Zadanie_Srednie
{
    internal class KrolikiJasia
    {


        //public static void Main()
        //{
        //    int liczbaZestawow = int.Parse(Console.ReadLine());
        //    if (liczbaZestawow >= 1 && liczbaZestawow <= 10000)
        //    {
        //        WprowadzenieDanych(liczbaZestawow);
        //    }
        //    else
        //    {
        //        Console.WriteLine($"Przekroczono zakres liczby prób. Twoja wartość to : {liczbaZestawow}");
        //    }
        //}


        // ANALIZA TEJ METODY PONIŻEK --------------
        public static int[] WprowadzenieDanych(int liczbaZestawow)
        {
            int[] wyniki = new int[liczbaZestawow * 2]; // Mnożenie przez 2, ponieważ każdy zestaw ma dwie liczby

            for (int i = 0; i < liczbaZestawow * 2; i += 2)
            {
                string[] liczbyString = Console.ReadLine().Split(' ');
                int[] liczbyInt = Array.ConvertAll(liczbyString, int.Parse);
                wyniki[i] = liczbyInt[0];
                wyniki[i + 1] = liczbyInt[1];
            }

            return wyniki;
        }


        public void MechanizmDzialaniaJasia()
        {

        }
    }
}
