using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

//namespace ConsoleApp48.Spoj_Zadanie_Srednie
//{
//    public class ZabawaWDwaOgnie
//    {

//        private int[,] znajomosci;
//        private int[] druzyna;
//        private bool sukces;

//        public ZabawaWDwaOgnie(int liczbaUczniow)
//        {
//            znajomosci = new int[liczbaUczniow, liczbaUczniow];
//            druzyna = new int[liczbaUczniow];
//            sukces = false;
//        }

//        public static void Main()
//        {
//            int liczbaUczniow = int.Parse(Console.ReadLine());

//            ZabawaWDwaOgnie zabawaWDwaOgnie = new ZabawaWDwaOgnie(liczbaUczniow);
//            if (liczbaUczniow >= 3 && liczbaUczniow <= 1000)
//            {
//                zabawaWDwaOgnie.WprowadzenieDanych();
//                zabawaWDwaOgnie.Rozwiazanie();

//                Console.ReadKey();
//            }
//            else
//            {
//                Console.WriteLine("Przekroczono zakres");
//            }
//        }


//        private void WprowadzenieDanych()
//        {
//            for (int i = 0; i <= znajomosci.GetLength(0); i++)
//            {
//                string[] tabString = Console.ReadLine().Split(' ');

//                for (int j = 0; j <= znajomosci.GetLength(1); i++)
//                {
//                    znajomosci[i, j] = int.Parse(tabString[j]);
//                }
//            }
//        }

//        public void Rozwiazanie()
//        {
//            int n = znajomosci.GetLength(0);
//            for (int a = 0; a < n && !sukces; a++)
//            {
//                for (int b = a + 1; b < n && !sukces; b++)
//                {
//                    for (int c = b + 1; c < n && !sukces; c++)
//                    {
//                        if (znajomosci[a, b] == 1 && znajomosci[b, c] == 1 && znajomosci[a, c] == 1)
//                        {
//                            druzyna[a] = druzyna[b] = druzyna[c] = 1;
//                            sukces = true;
//                        }
//                    }
//                }
//            }
//            if(sukces)
//            {
//                Console.WriteLine("TAK");
//                for(int i =0; i<n; i++)
//                {
//                    if (druzyna[i] ==1)
//                    {
//                        Console.WriteLine(" " + (i+1));
//                    }
//                }
//            }
//            else
//            {
//                Console.WriteLine("NIE");
//            }
//        }
//    }
//}

//-----------
//-----------------------------------------------UŻYCIE Z DELEGATEM------------------------
namespace ConsoleApp48.Spoj_Zadanie_Srednie
{ 
public class ZabawaWDwaOgnie
{

    private int[,] znajomosci;
    private int[] druzyna;
    private bool sukces;

    public ZabawaWDwaOgnie(int liczbaUczniow)
    {
        znajomosci = new int[liczbaUczniow, liczbaUczniow];
        druzyna = new int[liczbaUczniow];
        sukces = false;
    }

    public delegate void DaneDelegate();
    public delegate void RozwiazanieDelegate();


    public void PrzetworzDane(DaneDelegate daneDelegate)
    {
        daneDelegate();
    }

    public void PrzetworzRozwiazanie(RozwiazanieDelegate rozwiazanieDelegate)
    {
        rozwiazanieDelegate();
    }

    //public static void Main()
    ////{
    //    int liczbaUczniow = int.Parse(Console.ReadLine());

    //    ZabawaWDwaOgnie zabawaWDwaOgnie = new ZabawaWDwaOgnie(liczbaUczniow);
    //    if (liczbaUczniow >= 3 && liczbaUczniow <= 1000)
    //    {
    //        zabawaWDwaOgnie.PrzetworzDane(zabawaWDwaOgnie.WprowadzenieDanych);
    //        zabawaWDwaOgnie.PrzetworzRozwiazanie(zabawaWDwaOgnie.Rozwiazanie);

    //        Console.ReadKey();
    //    }
    //    else
    //    {
    //        Console.WriteLine("Przekroczono zakres");
    //    }
    //}


    private void WprowadzenieDanych()
    {
        for (int i = 0; i <= znajomosci.GetLength(0); i++)
        {
            string[] tabString = Console.ReadLine().Split(' ');

            for (int j = 0; j <= znajomosci.GetLength(1); i++)
            {
                znajomosci[i, j] = int.Parse(tabString[j]);
            }
        }
    }

    public void Rozwiazanie()
    {
        int n = znajomosci.GetLength(0);
        for (int a = 0; a < n && !sukces; a++)
        {
            for (int b = a + 1; b < n && !sukces; b++)
            {
                for (int c = b + 1; c < n && !sukces; c++)
                {
                    if (znajomosci[a, b] == 1 && znajomosci[b, c] == 1 && znajomosci[a, c] == 1)
                    {
                        druzyna[a] = druzyna[b] = druzyna[c] = 1;
                        sukces = true;
                    }
                }
            }
        }
        if (sukces)
        {
            Console.WriteLine("TAK");
            for (int i = 0; i < n; i++)
            {
                if (druzyna[i] == 1)
                {
                    Console.WriteLine(" " + (i + 1));
                }
            }
        }
        else
        {
            Console.WriteLine("NIE");
        }
    }
}
}
