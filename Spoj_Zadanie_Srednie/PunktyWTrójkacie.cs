using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp48.Spoj_Zadanie_Srednie
{
    internal class PunktyWTrójkacie
    {

        //public static void Main()
        //{
        //    PunktyWTrójkacie punktyWTrójkacie = new PunktyWTrójkacie();
        //    int[] wprowadzenie = punktyWTrójkacie.WprowadzanieDanych();
        //    string logika = punktyWTrójkacie.LogikaStringa(wprowadzenie);
        //    Console.WriteLine(logika);
        //}

        public int[] WprowadzanieDanych()
        {
            int[] DaneTrojkata = new int[8];
            for (int i = 0; i < 7; i++)
            {
                DaneTrojkata[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("0000000000000000");
            return DaneTrojkata;
        }
        public string LogikaStringa(int[] wpro)
        {
            int x1 = wpro[0];
            int y1 = wpro[1];
            int x2 = wpro[2];
            int y2 = wpro[3];
            int x3 = wpro[4];
            int y3 = wpro[5];
            int x = wpro[6];
            int y = wpro[7];
            string litery = "";

            int orientacja = (x2 - x1) * (y - y1) - (x - x1) * (y2 - y1);
            int orientacja2 = (x3 - x2) * (y - y2) - (x - x2) * (y3 - y2);
            int orientacja3 = (x1 - x3) * (y - y3) - (x - x3) * (y1 - y3);

            if (orientacja == 0 && orientacja2 == 0 && orientacja3 == 0)
            {
                return "I\n";
            }
            else if (orientacja >= 0 && orientacja2 >= 0 && orientacja3 >= 0 ||
                     orientacja <= 0 && orientacja2 <= 0 && orientacja3 <= 0)
            {
                return "E\n";
            }
            else
            {
                return "O\n";
            }
        }
    }
    //-------------------------------------------ZAPISANIE Z UŻYCIEM DELEGATÓW-----------------------------------------------

    //internal class PunktyWTrójkacieDELEGATY
    //{
    //    public delegate string LogiktaStringDelegatu(int[] wpro);
    //    public static void Main()
    //    {
    //        PunktyWTrójkacie punktyWTrójkacie = new PunktyWTrójkacie();
    //        int[] wprowadzenie = punktyWTrójkacie.WprowadzanieDanych();

    //        LogiktaStringDelegatu logiktaStringDelegatu = new LogiktaStringDelegatu(punktyWTrójkacie.LogikaStringa);
    //        string log = logiktaStringDelegatu(wprowadzenie);
    //        Console.WriteLine(log);
    //    }

    //    public int[] WprowadzanieDanych()
    //    {
    //        int[] DaneTrojkata = new int[8];
    //        for (int i = 0; i < 7; i++)
    //        {
    //            DaneTrojkata[i] = int.Parse(Console.ReadLine());
    //        }
    //        Console.WriteLine("0000000000000000");
    //        return DaneTrojkata;
    //    }
    //    public string LogikaStringa(int[] wpro)
    //    {
    //        int x1 = wpro[0];
    //        int y1 = wpro[1];
    //        int x2 = wpro[2];
    //        int y2 = wpro[3];
    //        int x3 = wpro[4];
    //        int y3 = wpro[5];
    //        int x = wpro[6];
    //        int y = wpro[7];
    //        string litery = "";

    //        int orientacja = (x2 - x1) * (y - y1) - (x - x1) * (y2 - y1);
    //        int orientacja2 = (x3 - x2) * (y - y2) - (x - x2) * (y3 - y2);
    //        int orientacja3 = (x1 - x3) * (y - y3) - (x - x3) * (y1 - y3);

    //        if (orientacja == 0 && orientacja2 == 0 && orientacja3 == 0)
    //        {
    //            return "I\n";
    //        }
    //        else if (orientacja >= 0 && orientacja2 >= 0 && orientacja3 >= 0 ||
    //                 orientacja <= 0 && orientacja2 <= 0 && orientacja3 <= 0)
    //        {
    //            return "E\n";
    //        }
    //        else
    //        {
    //            return "O\n";
    //        }
    //    }
    //}
}


  
