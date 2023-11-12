using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp48.Linq
{
    public class ProsteZadanieLinqu1
    {
        //public static void Main()
        //{
        //    MetodaSobie();
            
        //}
        public static int MetodaSobie()
        {
            List<int> liczby = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            int sumaLiczb = liczby.Where(x => x % 2 == 0).Sum();
            return sumaLiczb; 
        }
    }
}
