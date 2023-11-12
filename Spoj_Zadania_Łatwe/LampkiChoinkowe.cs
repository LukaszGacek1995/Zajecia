using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp48
{
    public class LampkiChoinkowe
    {

        //public static void Main(string[] args)
        //{
        //    LampkiChoinkowe lampkiChoinkowe = new LampkiChoinkowe();

        //    int[] wprowadzanie = lampkiChoinkowe.WprowadzanieDanych();
        //    int mechanizm = lampkiChoinkowe.MechanizmSprawdzania(wprowadzanie[0], wprowadzanie[1], wprowadzanie[2]);


        //    Console.WriteLine("Maksymalna liczba świecących żarówek" + mechanizm);
        //    Console.ReadKey();
        //}

        public int[] WprowadzanieDanych()
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            if ((n >= 0 && n < 1000) && (m >= 0 && m < 1000))
            {
                int[] tablicaWejsciowych = new int[3];
                n = tablicaWejsciowych[0];
                m = tablicaWejsciowych[1];
                k = tablicaWejsciowych[2];

                return tablicaWejsciowych;
            }
            else
            {
                throw new Exception("Przkroczono zakres");
            }
        }

        public int MechanizmSprawdzania(int n, int m, int k)
        {
            if (n > m)
            {
                return Math.Min(n - k + m, n + m - k);
            }
            else if (m > n)
            {
                return Math.Min(m - k + n, n + m - k);
            }
            else if (n == m)
            {
                return n + m - k;
            }
            throw new Exception("Nie prawidłowe dane");
        }
    }
}
