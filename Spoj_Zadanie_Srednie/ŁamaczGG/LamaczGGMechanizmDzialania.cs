using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp48.Spoj_Zadanie_Srednie.ŁamaczGG
{
    internal class LamaczGGMechanizmDzialania
    {
        public List<string> Lamacz(List<string> liste)
        {

            List<string> odkodowaneHadlo = new List<string>();

            foreach (string haslo in liste)
            {
                string odkowaneHadlo = OdkodujHaslo(haslo);
                odkodowaneHadlo.Add(odkowaneHadlo);
            }

            return null;
        }
        private string OdkodujHaslo(string haslo)
        {
            string odkodowaneHaslo = "";
            string alfabet = "ABCDEFGHIJKLMNOP";
            string odpowiadajaceLitery = "abcdefghijklmnop";

            foreach (char litera in haslo)
            {
                int index = alfabet.IndexOf(litera);

                if (index != -1)
                {
                    odkodowaneHaslo += odpowiadajaceLitery[index];
                }
            }
            return odkodowaneHaslo;
        }
    }
}
