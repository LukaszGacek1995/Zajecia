using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp48.Indexery
{
    internal class IndexeryNaSZtywno7
    {

        private Dictionary<string, int> slownik = new Dictionary<string, int>();

        public int this[string klucz]
        {
            get { return slownik[klucz]; }
            set { slownik[klucz] = value; }

        }
        public class Progg
        {
            //public static void Main()
            //{
            //    IndexeryNaSZtywno7 indexeryNaSZtywno7 = new IndexeryNaSZtywno7();
            //    indexeryNaSZtywno7["JEDEN"] = 21;
            //}
        }                                                                                                                                                                                                                                            
    }
}
