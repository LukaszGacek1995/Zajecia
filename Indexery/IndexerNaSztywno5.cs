using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp48.Indexery
{
    internal class IndexerNaSztywno5
    {
       string[] tab = new string[4];
       
        public string this[int index]
        {
            get { return tab[index]; }
            set { tab[index] = value; } 
        }
        
    }

    public class Prgo
    {
        //public static void Main()
        //{
        //    IndexerNaSztywno5 indexerNaSztywno5     = new IndexerNaSztywno5();
        //    indexerNaSztywno5[3] = "Wartosśc string";
        //}
    }
}
