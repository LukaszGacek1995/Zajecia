using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp48.Delegaty
{
    public delegate double DzialnieMatamtyczneDelegat(double a, double b);
    public class OperacjaMatematycznaDelegat
    {
        //public static void Main(string[] args)
        //{
        //    OperacjaMatematycznaDelegat d = new OperacjaMatematycznaDelegat();

        //    DzialnieMatamtyczneDelegat instancjaDelegatu = new DzialnieMatamtyczneDelegat(d.Dodaj);
        //     double wynik =  instancjaDelegatu(2, 5);

        //    DzialnieMatamtyczneDelegat instancjaDelegatuDWA = new DzialnieMatamtyczneDelegat(d.Pomoz);
        //    double wynik2 =  instancjaDelegatuDWA(3, 5);

        //    Console.WriteLine(wynik + "oraz" + wynik2);
        //    Console.ReadKey();

        //}


        public double Dodaj(double a, double b)
        {
            return a + b;
        }

        public double Pomoz(double a, double b)
        {
            return a * b;
        }
        Func<int, int, int> add = (a, b) => a + b;

    }
}
