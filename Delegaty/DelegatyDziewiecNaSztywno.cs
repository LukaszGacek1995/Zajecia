using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp48.Delegaty
{
    public class DelegatyDziewiecNaSztywno
    {
        public delegate int NazwaDelegatu(int x, int y);

        public int MetodaPierwsza(int x, int y)
        {
            return x + y;
        }

        public int MetodaDruga(int x, int y)
        {
            return x - y;
        }

        //public static void Main()
        //{
        //    DelegatyDziewiecNaSztywno delegatyDziewiecNaSztywno = new DelegatyDziewiecNaSztywno();
        //    NazwaDelegatu delegacik = new NazwaDelegatu(delegatyDziewiecNaSztywno.MetodaPierwsza);
        //    delegacik(2, 6);


        //    NazwaDelegatu del = new NazwaDelegatu(delegatyDziewiecNaSztywno.MetodaDruga);
        //    del(6, 7);
        //}
    }
}
