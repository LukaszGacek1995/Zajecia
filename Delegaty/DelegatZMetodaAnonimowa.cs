using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp48.Delegaty
{
    public delegate int Dek(int x, int y);
    public class DelegatZMetodaAnonimowa
    {

        Dek dd = delegate (int x, int y)
        {
            return x * y;
        };

        
        //public static void Main()
        //{
        //    DelegatZMetodaAnonimowa d = new DelegatZMetodaAnonimowa();
        //    int ele = d.dd(2, 3);
 
        //    Console.WriteLine(ele);
        //}
    }
}
