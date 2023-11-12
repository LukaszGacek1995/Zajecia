using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp48.Delegaty
{
    public class DelegatyAction1NaSztywno
    {
        public int Dodaj(int a, int b)
        {
            return a + b;
        }

        public int Pomnoz(int a, int b)
        {
            return a * b;
        }
    }

    class Program1
    {
        //static void Main()
        //{
        //    DelegatyAction1NaSztywno delegatyAction1NaSztywno = new DelegatyAction1NaSztywno();

        //    Action<int, int> actiondzialnie = (x, y) =>
        //    {
        //        int elo1 = delegatyAction1NaSztywno.Dodaj(x, y);
        //        Console.WriteLine(elo1);
        //    };

        //    Action<int, int> actionDZialnieDwa = (x, y) => 
        //    {
        //        int eloszka = delegatyAction1NaSztywno.Pomnoz(x, y);
        //        Console.WriteLine(eloszka);
        //    };

        //    actiondzialnie(3, 2);
        //    actionDZialnieDwa(4, 5);
        //}
    }
}
