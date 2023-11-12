//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//using System;

//namespace ConsoleApp
//{
//    //public class KubkiZCzekolada
    //{
    //    public static void Main(string[] args)
    //    {
    //        KubkiZCzekolada kubkiZCzekolada = new KubkiZCzekolada();
    //        var daneWejsciowe = kubkiZCzekolada.WprowadzanieDanych();

    //        int[] ostateczneZawartosci = kubkiZCzekolada.MechanizmDzialania(daneWejsciowe.n, daneWejsciowe.p, daneWejsciowe.poczatkoweZawartosci, daneWejsciowe.q, daneWejsciowe.numeryKubkow);

    //        foreach (int zawartosc in ostateczneZawartosci)
    //        {
    //            Console.WriteLine(zawartosc);
    //        }
    //    }

    //    public (int n, int p, int[] poczatkoweZawartosci, int q, int[] numeryKubkow) WprowadzanieDanych()
    //    {
    //        string[] dane = Console.ReadLine().Split(' ');
    //        int n = int.Parse(dane[0]);
    //        int p = int.Parse(dane[1]);

    //        if (n <= 0 || n >= 2001 || p <= 0 || p >= 2001)
    //        {
    //            throw new Exception("Przekroczono zakres, spróbuj jeszcze raz");
    //        }

    //        int[] poczatkoweZawartosci = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

    //        int q = int.Parse(Console.ReadLine());

    //        if (q > 2000)
    //        {
    //            throw new Exception("Przekroczono zakres, spróbuj jeszcze raz");
    //        }

    //        int[] numeryKubkow = new int[q];

    //        for (int i = 0; i < q; i++)
    //        {
    //            numeryKubkow[i] = int.Parse(Console.ReadLine());
    //        }

    //        return (n, p, poczatkoweZawartosci, q, numeryKubkow);
    //    }

    //    public int[] MechanizmDzialania(int n, int p, int[] poczatkoweZawartosci, int q, int[] numeryKubkow)
    //    {
    //        int[] ostateczneZawartosci = new int[q];

    //        for (int i = 0; i < q; i++)
    //        {
    //            int numerKubka = numeryKubkow[i];
    //            int aktualnaZawartosc = poczatkoweZawartosci[numerKubka - 1];

    //            int cykl = 0;

    //            while (true)
    //            {
    //                int nastepnyKubek = (numerKubka + cykl + 1) % n;
    //                int przelanaCzekolada = Math.Min(aktualnaZawartosc, p - poczatkoweZawartosci[nastepnyKubek]);
                    
    //                aktualnaZawartosc -= przelanaCzekolada;
    //                poczatkoweZawartosci[nastepnyKubek] += przelanaCzekolada;

    //                if (przelanaCzekolada == 0)
    //                {
    //                    break;
    //                }

    //                cykl++;
    //            }

    //            ostateczneZawartosci[i] = aktualnaZawartosc;
    //        }

    //        return ostateczneZawartosci;
//    //    }
//    }
//}