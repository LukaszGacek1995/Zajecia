using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp48.Spoj_Zadanie_Srednie
{
    internal class SmiercionosneJablka
    {
        //public static void Main()
        //{
        //    SmiercionosneJablka smiercionosneJablka = new SmiercionosneJablka();
        //    Tuple<int, int, int[]> wprowadzanieDanych = smiercionosneJablka.WprowadzenieDanych();
        //}

        public Tuple<int, int, int[]> WprowadzenieDanych()
        {
            int liczbatestow = int.Parse(Console.ReadLine());
            int liczbaPomiarow = int.Parse(Console.ReadLine());

            int[] pomiary = new int[liczbaPomiarow];

            for(int i =0; i<liczbaPomiarow; i++)
            {
                pomiary[i] = int.Parse(Console.ReadLine());
            }

            return Tuple.Create(liczbatestow, liczbaPomiarow, pomiary);
        }
    }
}
