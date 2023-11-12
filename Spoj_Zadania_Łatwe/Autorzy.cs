using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp48
{
    public class Autorzy
    {
        //public static void Main(string[] args)
        //{
        //    Autorzy auto = new Autorzy();
        //    long final = auto.WprowadzaniDanych();
        //    Console.WriteLine(final);

        //    Console.ReadKey();
        //}

        public long WprowadzaniDanych()
        {
            long g = int.Parse(Console.ReadLine());
            long m = int.Parse(Console.ReadLine());

            if(g>0 && m <= 100000)
            {
                long pieniadzePierwszego = (int)Math.Pow(10, g);
                long pieniadzeDrugiego = (int)Math.Pow(10, m);
               return Dodawanie(pieniadzePierwszego, pieniadzeDrugiego);
            }
            else
            {
                throw new Exception("błędny zakres");
            }
            return 0;
        }
        public long Dodawanie(long pieniadzePierwszego, long pieniadzeDrugiego)
        {
            long sumaObu = pieniadzePierwszego + pieniadzeDrugiego;
            return sumaObu;
        }
    }
}
