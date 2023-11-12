using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp48
{
    public class LiczbyPierwsze
    {
        //public static void Main(string[] args)
        ////{
        //    LiczbyPierwsze liczbyPierwsze = new LiczbyPierwsze();
        //    int[] wprowadzenie = liczbyPierwsze.MechanizDodawniaWartosci();
        //    int liczbyPierwszeeee = liczbyPierwsze.ZnajdzLiczbyPierwsze(wprowadzenie);
        //    Console.WriteLine(liczbyPierwszeeee);
        //}
        public int[] MechanizDodawniaWartosci()
        {
            string[] wprowadzeni = Console.ReadLine().Split(' ');
            
            int[] wynik1 = new int[wprowadzeni.Length];

            for (int i = 0; i < wprowadzeni.Length; i++)
            {
                int wproInt = int.Parse(wprowadzeni[i]);
                wynik1[i] = wproInt;
            }
            return wynik1;
        }

        public int ZnajdzLiczbyPierwsze(int[] wynik)
        {
            int Count = 0;
            foreach (var petlaOblicza in wynik)
            {
                Count++;
            }
            return Count;
        }

        public bool CzyLiczbyPierwsze(int liczba)
        {
           if(liczba<2)
            {
                return false;
            }
            for(int i = 2; i<= Math.Sqrt(liczba); i++)
            {
                if (liczba % i == 0)
                {
                    return false;
                }
            }
            return true;
           
        }
    }
}
