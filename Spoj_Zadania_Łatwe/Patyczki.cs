using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp48
{
    public class Patyczki
    {
        //public static void Main(string[] args)
        //{
        //    Patyczki patyczki = new Patyczki();

        //    int[] daneWejsciowe = patyczki.DaneWejsciowe();
        //    int liczbaTrojkatow = patyczki.WyznaczLiczbeTrojkatow(daneWejsciowe);
        //    Console.WriteLine(liczbaTrojkatow);
        //    Console.ReadKey();
        //}

        public int[] DaneWejsciowe()
        {
            int n = int.Parse(Console.ReadLine());
            string[] patyczki = Console.ReadLine().Split(' ');
            if (patyczki.Length == n)
            {
                int[] patyczkiINT = new int[n];

                for (int i = 0; i < n; i++)
                {
                    patyczkiINT[i] = int.Parse(patyczki[i]);
                }
                return patyczkiINT;
            }
            throw new Exception("Nieprawidłowe dane wejściowe");
        }

        public int WyznaczLiczbeTrojkatow(int[] patyczki)
        {
            Array.Sort(patyczki); // Sortowanie patyczków w celu łatwiejszego wykrywania trójkątów

            int liczbaTrojkatow = 0;
            int n = patyczki.Length;

            for (int i = 0; i < n - 2; i++)
            {
                for (int j = i + 1; j < n - 1; j++)
                {
                    for (int k = j + 1; k < n; k++)
                    {
                        if (CzyTrojkatRownoboczny(patyczki[i], patyczki[j], patyczki[k]))
                        {
                            liczbaTrojkatow++;
                        }
                    }
                }
            }

            return liczbaTrojkatow;
        }

        public bool CzyTrojkatRownoboczny(int a, int b, int c)
        {
            return a == b && b == c;
        }
    }
}
