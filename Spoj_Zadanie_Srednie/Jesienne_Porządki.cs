using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
namespace ConsoleApp48.Spoj_Zadanie_Srednie
{
    public class Jesienne_Porządki
    {
        //public static void Main()
        //{
        //    int liczbaKopcow = int.Parse(Console.ReadLine());
        //    List<Tuple<int, int>> kopce = new List<Tuple<int, int>>();

        //    for (int i = 0; i < liczbaKopcow; i++)
        //    {
        //        string wprowadzenieWartosciString = Console.ReadLine();
        //        string[] rozdzielenieWprowadzonychWartosci = wprowadzenieWartosciString.Split(' ');

        //        if (rozdzielenieWprowadzonychWartosci.Length == 2)
        //        {
        //            int x = int.Parse(rozdzielenieWprowadzonychWartosci[0]);
        //            int y = int.Parse(rozdzielenieWprowadzonychWartosci[1]);

        //            if (x > -100000 && x < 10000)
        //            {
        //                kopce.Add(Tuple.Create(x, y));
        //            }
        //            else
        //            {
        //                Console.WriteLine("Przekroczono zakres");
        //            }
        //        }
        //        else
        //        {
        //            Console.WriteLine("Wpisałeś więcej niż dwie niezbędne wartości");
        //        }
        //    }
        //    kopce = kopce.OrderBy(t => t.Item1).ToList();

        //    int xOgniska = kopce[liczbaKopcow/2].Item1;

        //    int lacznaDroga = 0;

        //    foreach(var k in kopce)
        //    {
        //        lacznaDroga += Math.Abs(k.Item1 - xOgniska) + k.Item2;
        //    }

        //    Console.WriteLine($"{xOgniska} {lacznaDroga}");

        //}
    }
}
