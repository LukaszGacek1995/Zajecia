using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp48
{
    public class CzujnikRuchu
    {
        //public static void
        //(string[] args)
        //{
        //    CzujnikRuchu czujnikRuchu = new CzujnikRuchu();

        //    int t = int.Parse(Console.ReadLine());

        //    for (int i = 0; i < t; i++)
        //    {
        //        string[] wprowadzeniedanychtablicy = czujnikRuchu.WprowadzenieDanych();
        //        int mechanizmDzialania = czujnikRuchu.MechanizmDzialania(wprowadzeniedanychtablicy);

        //        if (mechanizmDzialania != -1)
        //        {
        //            Console.WriteLine(mechanizmDzialania.ToString());
        //        }
        //        else
        //        {
        //            Console.WriteLine("ERROR");
        //        }
        //    }
        //    Console.ReadKey();

        //}

        public string[] WprowadzenieDanych()
        {
           
            int n = int.Parse(Console.ReadLine());

            string[] tablicaWprowadzanKlient = new string[n];

            for (int i = 0; i < n; i++)
            {
                tablicaWprowadzanKlient[i] = Console.ReadLine();
            }

            return tablicaWprowadzanKlient;
        }


        public int MechanizmDzialania(string[] tablicaWprowadzenKlienta)
        {
            
                int liczenieAI = 0;
                int liczenieAO = 0;
                int liczenieBI = 0;
                int liczebueBO = 0;

                foreach (var petlaIteracja in tablicaWprowadzenKlienta)
                {
                    if (petlaIteracja == "AI")
                    {
                        liczenieAI++;  // np.2
                    }
                    else if (petlaIteracja == "AO")
                    {
                        liczenieAO++;  //2
                    }
                    else if (petlaIteracja == "BI")
                    {
                        liczenieBI++; //2
                    }
                    else if (petlaIteracja == "BO")
                    {
                        liczebueBO++;  //1
                    }
                }

                
                if (liczenieAI == liczebueBO && liczenieBI == liczenieAO)
                {
                    return (liczenieAI + liczenieBI);
                }
                else
                {
                return -1;
                }
            
           
        }
    }
}
