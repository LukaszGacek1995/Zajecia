using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp48.Delegaty
{
    public delegate int NazwaDlegatu(int a, int b);
    public class DelegateSzostyNaSztywno
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Substract(int a, int b)
        {
            return a - b;
        }

        //public static void Main()
        //{
        //    DelegateSzostyNaSztywno delegateSzostyNaSztywno = new DelegateSzostyNaSztywno();

        //    NazwaDelegatu del = new NazwaDelegatu(delegateSzostyNaSztywno.Add);
        //    int pierwsza = del(2, 5);
        //    Console.WriteLine("wynikDodania:" + pierwsza);


        //    NazwaDelegatuDwa dwa = new NazwaDelegatuDwa(delegateSzostyNaSztywno.Substract);
        //    int ee = dwa(4, 6);
        //    Console.WriteLine("wynik dwa:" + ee);
        //}
    }
}
