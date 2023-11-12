using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp48.Delegaty
{
    delegate int NazwaDelegatu(int a, int b);
    public class DelegatPrzykladDrugiNaSzytwno
    {
        //static void Main()
        //{

        //    NazwaDelegatu nazwaDelegatu = new NazwaDelegatu(Add);
        //    int wywolanie = nazwaDelegatu(2, 3);
        //    Console.WriteLine(wywolanie);
        //}

        static  int Add(int a, int b)
        {
            return a + b;
        }
    }
}
