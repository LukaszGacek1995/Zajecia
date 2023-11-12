using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp48.Delegaty
{
    public delegate int NazwaDelegatuDwa(int x, int y);
    public class DelegatPrzykladCzwartyNaSztywno
    {
        //public static void Main()
        //{
        //    DelegatPrzykladCzwartyNaSztywno instacjaCztery = new DelegatPrzykladCzwartyNaSztywno();
        //    NazwaDelegatuDwa nazwaDel = new NazwaDelegatuDwa(instacjaCztery.Add);
        //    int i  = nazwaDel(1, 2);
        //    Console.WriteLine("Wynik" + i);
        //    Console.ReadLine();


        //}

        public int Add(int x, int y)
        {
            return x + y;
        }
    }
}
