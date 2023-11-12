using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp48
{
    public class NaiwnySzyfr
    {
        //public static void Main(string[] args)
        //{
        //    NaiwnySzyfr naiwnySzyfr= new NaiwnySzyfr();
        //    string zaszyfrowaneHaslo = naiwnySzyfr.WprowadzanieDanych();
        //    string rozszyfrowaneHaslo = naiwnySzyfr.RozszyfrujHaslo(zaszyfrowaneHaslo);
        //    Console.WriteLine(rozszyfrowaneHaslo);

        //}

        private string WprowadzanieDanych()
        {
            string wprowadzoneHaslo = Console.ReadLine();
            int dlugosc = wprowadzoneHaslo.Length;
            if (dlugosc <= 1000000)
            {
                if (WeryfikacjiaWielkosciLiter(wprowadzoneHaslo))
                {
                    return wprowadzoneHaslo;
                }
            }
            else
            {
                throw new Exception("przekroczono zakres");
            }
            return null;
        }

        private bool WeryfikacjiaWielkosciLiter(string wprowadzoneHasloPrzekzanie)
        {
            foreach(char weryfice in wprowadzoneHasloPrzekzanie)
            {
                if(!Char.IsLower(weryfice))
                {
                    return false;
                }
            }
            return true;
        }




        private string RozszyfrujHaslo(string zaszyfrowaneHaslo)
        {
            int dlugosc = zaszyfrowaneHaslo.Length;
            char[] rozszyfrowaneZnaki = zaszyfrowaneHaslo.ToCharArray();



            for(int i = dlugosc - 1; i>=1; i--)
            {
                int start = 0;
                int end = i;
                while(start<end)
                {
                    char temp = rozszyfrowaneZnaki[start];
                    rozszyfrowaneZnaki[start] = rozszyfrowaneZnaki[end];
                    rozszyfrowaneZnaki[end] = temp;

                    start++;
                    end--;

                }
            }
            return new string(rozszyfrowaneZnaki);
        }

    }
}
