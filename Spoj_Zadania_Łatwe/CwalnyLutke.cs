using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp48.Spoj_Zadania_Łatwe
{
    public class CwalnyLutke
    {


        //public static void Main()
        //{
        //    MechanizmZbieraniaDanych mechanizmZbieraniaDanych = new MechanizmZbieraniaDanych();
        //    Tuple<int, int[][]> mechanizmDaneWejsc = mechanizmZbieraniaDanych.DaneWejsciowe();

        //    MechanizDzialaniaLutek mechanizDzialaniaLutek = new MechanizDzialaniaLutek();
        //    string wynikZLogiki = mechanizDzialaniaLutek.LogikaCwanyLutek(mechanizmDaneWejsc);

        //    Console.WriteLine(wynikZLogiki);
        //}
    }

    public class MechanizmZbieraniaDanych
    {
        public Tuple<int, int[][]> DaneWejsciowe()
        {
            int iloscZestawow = int.Parse(Console.ReadLine());

            int[][] wszystkieZestawy = new int[iloscZestawow][];
            if (iloscZestawow >= 1 && iloscZestawow <= 10000000)
            {
                for (int i = 0; i < iloscZestawow; i++)
                {
                    string wprowadzenie = Console.ReadLine();
                    string[] wprowadzanieListaStr = wprowadzenie.Split(' ');
                    int[] wprowadznieListaInt = new int[wprowadzanieListaStr.Length];

                    for (int j = 0; j < wprowadzanieListaStr.Length; j++)
                    {
                        wprowadznieListaInt[j] = int.Parse(wprowadzanieListaStr[j]);
                    }

                    wszystkieZestawy[i] = wprowadznieListaInt;
                }
            }
            else
            {
                Console.WriteLine("Wybrano wartosc z poza zakresu");
            }

            return Tuple.Create(iloscZestawow, wszystkieZestawy);
        }
    }
    public class MechanizDzialaniaLutek
    {
        public string LogikaCwanyLutek(Tuple<int, int[][]> PrzekazaniemechanizDzialaniaLutek)
        {
            string wynik = "";
            foreach (var zestaw in PrzekazaniemechanizDzialaniaLutek.Item2)
            {
                int N = zestaw[0];
                int K = zestaw[1];


                if (CountWaysIsEvent(N,K))
                {
                    wynik += "P\n";
                }
                else
                {
                    wynik += "N\n";
                }
            }
            return wynik;
        }
            
        
    private bool CountWaysIsEvent(int N, int K)
        {
            return K <= N / 2;
        }
    }
}


