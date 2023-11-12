using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp48.Spoj_Zadanie_Srednie.SzyfrowanieSzyfrowanie2
{

    class Program

    {

        //static void Main()
        //{

        //    int t = int.Parse(Console.ReadLine()); // Wczytaj liczbę testów

        //    for (int i = 0; i < t; i++)
        //    {
        //        int n = int.Parse(Console.ReadLine()); // Wczytaj liczbę liter w ciągu
        //        int[] numbers = new int[n]; // Tablica na wczytane liczby trzycyfrowe
        //        int[] result = new int[n]; // Tablica na wynikowe liczby ASCII
        //        string[] input = Console.ReadLine().Split(' ');
                
        //        for (int j = 0; j < n; j++)
        //        {
        //            numbers[j] = int.Parse(input[j]);
        //        }
        //        bool codeFound = false;

        //        for (int code = 120; code <= 150; code++)
        //        {

        //            bool validCode = true;

        //            for (int j = 0; j < n; j++)
        //            {

        //                if (numbers[j] % code != 0 || numbers[j] / code > 999)
        //                {
        //                    validCode = false;
        //                    break;
        //                }
        //                result[j] = numbers[j] / code;
        //            }

        //            if (validCode)
        //            {

        //                codeFound = true;

        //                Console.Write(code + " ");

        //                for (int j = 0; j < n; j++)
        //                {
        //                    char c = (char)result[j];
        //                    if (c < 'A' || c > 'Z')
        //                    {
        //                        validCode = false;
        //                        break;
        //                    }
        //                    Console.Write(c);
        //                }
        //                Console.WriteLine();
        //                break;
        //            }
        //        }
        //        if (!codeFound)
        //        {
        //            Console.WriteLine("NIECZYTELNE");
        //        }
        //    }
        //}
    }
}
