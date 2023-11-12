using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Net.WebSockets;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp48
{
    //public class Program
    //{
    //    //public static void Main(string[] args)
    //    //{
    //    //    GraWKulki produkt = new GraWKulki();
    //    //    produkt.WprowadzanieDanych();

    //    //    Console.ReadLine();
    //    }
    //}

    public class GraWKulki
    {
        public void WprowadzanieDanych()
        {
            string[] wspolrzedneMiski = Console.ReadLine().Split(' ');
            int wspolrzednaPierwsza = int.Parse(wspolrzedneMiski[0]);
            int wspolrzednaDruga = int.Parse(wspolrzedneMiski[1]);
            int promien = int.Parse(wspolrzedneMiski[2]);
            int liczbaRzutow = int.Parse(wspolrzedneMiski[3]);

            int liczbaUczestnikow = int.Parse(Console.ReadLine());

            string[] imiona = new string[liczbaUczestnikow];
            int[,] wspolrzedneUczestnikow = new int[liczbaUczestnikow, liczbaRzutow];
            int[] trafieniaUczestnikow = new int[liczbaUczestnikow];

            for (int i = 0; i < liczbaUczestnikow; i++)
            {
                imiona[i] = Console.ReadLine();

                for (int j = 0; j < liczbaRzutow; j++)
                {
                    string[] wspolrzedne = Console.ReadLine().Split(' ');
                    int wspolrzednaX = int.Parse(wspolrzedne[0]);
                    int wspolrzednaY = int.Parse(wspolrzedne[1]);
                    wspolrzedneUczestnikow[i, j] = ObliczOdleglosc(wspolrzednaX, wspolrzednaY, wspolrzednaPierwsza, wspolrzednaDruga);
                    if (wspolrzedneUczestnikow[i, j] <= promien)
                    {
                        trafieniaUczestnikow[i]++;
                    }
                }
            }

            int maxTrafien = 0;
            int indeksWygranego = 0;

            for (int i = 0; i < liczbaUczestnikow; i++)
            {
                if (trafieniaUczestnikow[i] > maxTrafien)
                {
                    maxTrafien = trafieniaUczestnikow[i];
                    indeksWygranego = i;
                }
            }

            Console.WriteLine(imiona[indeksWygranego] + " " + maxTrafien);
        }

        private int ObliczOdleglosc(int x1, int y1, int x2, int y2)
        {
            int odlegloscX = x1 - x2;
            int odlegloscY = y1 - y2;
            return (int)Math.Sqrt(odlegloscX * odlegloscX + odlegloscY * odlegloscY);
        }
    }
}
