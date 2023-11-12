using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp48.Indexery
{
    internal class IndexeryNaSztywno4
    {
        private int[] kolkcjaTablica = new int[10];

        public int this[int index]
        {
            get { return kolkcjaTablica[index]; }
            set { kolkcjaTablica[index] = value; }
        }
    }

    //public static void Main()
    //{
    //    IndexeryNaSztywno4 indexeryNaSztywno4 = new IndexeryNaSztywno4();
    //    indexeryNaSztywno4[2] = 31;
    //}
}
