using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp48.Indexery
{
    internal class IndexerNaSztywno6
    {
        private int[,] tabl = new int[10, 10];

        public int this[int index1, int index2]
        {
            get { return tabl[index1, index2]; }
            set { tabl[index1, index2] = value; }
        }
        public class Prog
        {
            //public static void Main()
            //{
            //    IndexerNaSztywno6 indexerNaSztywno6 = new IndexerNaSztywno6();
            //    indexerNaSztywno6[9, 0] = 31;
            //}
        }
    }
}
