using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp48.Indexery
{
    internal class IndexeryNaSztywno3
    {

        private List<string> listaIndexery = new List<string>();

        public string this[int index]
        {
            get { return listaIndexery[index]; }
            set { listaIndexery[index] = value; }
        }

        public void AddWord(string word)
        {
            listaIndexery.Add(word);
        }
        //public static void Main()
        //{
        //    IndexeryNaSztywno3 indexeryNaSztywno3 = new IndexeryNaSztywno3();
        //    indexeryNaSztywno3.AddWord("sasa");
        //    indexeryNaSztywno3.AddWord("dadsa");

        //    Console.WriteLine(indexeryNaSztywno3[0]);
        //    Console.WriteLine(indexeryNaSztywno3[1]);
        //}
    }
}
