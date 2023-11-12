using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp48.Linq
{
    public class ProsteZadanieLinq3
    {
        //public static void Main()
        //{
        //    int poczatek = 1;
        //    int koniec = 50;

        //    ProsteZadanieLinq3 prosteZadanieLinq3 = new ProsteZadanieLinq3();

        //    var liczbyPierwsze = Enumerable.Range(poczatek, koniec )
        //                         .Where(prosteZadanieLinq3.MechanizmWyliczaniaLiczbPierwszych);

        //    Console.WriteLine(liczbyPierwsze);

        //}


        public bool MechanizmWyliczaniaLiczbPierwszych(int liczba)
        {
            if(liczba <= 1)
            {
                return false;
            }

            if(liczba ==2)
            {
                return true;
            }
            if(liczba %2 == 0) 
            {
                return false;
            }
            for( int i = 3; i<= Math.Sqrt(liczba); i++)
            {
                if (liczba % 2 == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
