using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp48.Indexery
{
    internal class IndexeryNaSztywno2
    {
        private int[,] tablicaDwoWymiarowa = new int[10, 10];

        public int this[int row, int col]
        {
            get { return tablicaDwoWymiarowa[row, col]; }
            set { tablicaDwoWymiarowa[row, col] = value; }
        }
        //public static void Main()
        //{
        //    IndexeryNaSztywno2 indexeryNaSztywno2 = new IndexeryNaSztywno2();
        //    indexeryNaSztywno2[0, 10] = 12;
        //    indexeryNaSztywno2[8, 2] = 10;
        //}
    }
}
