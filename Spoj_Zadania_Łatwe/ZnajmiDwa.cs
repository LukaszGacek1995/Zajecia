using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

//namespace ConsoleApp48.Spoj_Zadania_Łatwe
//{
//    public class ZnajmiDwa
//    {

//        public static void Main()
//        {
//            ZnajmiDwa znajmiDwa = new ZnajmiDwa();
//            List<string> wprowadzanie = znajmiDwa.WprowadzanieDanych();

//            // zamiana wszystkich wartości string na dużelistry przy pomocy LINQU
//            List<string> tylkoDuzeLitery = wprowadzanie.Where(x => x.All(char.IsUpper)).ToList();

//            bool wszytskieDuzeLitery = tylkoDuzeLitery.Count == wprowadzanie.Count;

//            if (wszytskieDuzeLitery)
//            {
//                List<string> mechanizmSprawdzaniaParZnajomuch = znajmiDwa.MechanizmSprawdzaniaParZnajomych(tylkoDuzeLitery);
//            }
//            else
//            {
//                Console.WriteLine("Niewszytskie indeksy są z dużych liter");
//            }

//        }

//        public List<string> WprowadzanieDanych()
//        {
//            int liczbaOsob = int.Parse(Console.ReadLine());
//            List<string> listaNazw = new List<string>();

//            for (int i = 0; i < liczbaOsob; i++)
//            {
//                string wprowadzenie = Console.ReadLine();
//                listaNazw.Add(wprowadzenie);
//            }

//            return listaNazw;
//        }

//        public Dictionary<string, List<string>> MechanizmSprawdzaniaParZnajomych(List<string> tylkoDuzeLiteryPrzekazanie)
//        {
//            Dictionary<string, List<string>> grupyPodobnych = new Dictionary<string, List<string>>();

//            foreach (var wywolanie in tylkoDuzeLiteryPrzekazanie)
//            {
//                foreach(var wywoalniePojedyncychLiter in wywolanie)
//                {
                    
//                }
//            }
//        }
//    }
//}
