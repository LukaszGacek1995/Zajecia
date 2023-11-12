using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp48
{
    public class RozmiarButow
    {
        private const double mile = 1.609;
        //public static void Main()
        //{
        //    RozmiarButow rozmiar = new RozmiarButow();

        //    int wprowaadzenieDystanstuKilometry = int.Parse(Console.ReadLine());
        //    double wprowadzeniePoPrzeliczeniuWMilach = wprowaadzenieDystanstuKilometry * mile;
        //    string opinia = rozmiar.OpiniaRodzicow(wprowadzeniePoPrzeliczeniuWMilach);


        //    Console.WriteLine(opinia);
        //    Console.ReadLine(); 
        //}

        

        public string OpiniaRodzicow(double wprowadzeniePoPrzeliczeniuWMilach)
        {
            
            if(wprowadzeniePoPrzeliczeniuWMilach > 0 && wprowadzeniePoPrzeliczeniuWMilach <300)
            {
                 return "NIE";
            }
            else if(wprowadzeniePoPrzeliczeniuWMilach >=300 && wprowadzeniePoPrzeliczeniuWMilach <500)
            {
                return "SPRAWDZIMY TWOJE OBECNE BUTY";
            }
            else if(wprowadzeniePoPrzeliczeniuWMilach >=500)
            {
                return"TAK";
            }
            throw new Exception(" jest z poza zakresu");
        }
    }
}
