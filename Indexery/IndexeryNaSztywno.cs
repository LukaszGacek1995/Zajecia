using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp48
{
    internal class IndexeryNaSztywno
    {
        private string[] data = new string[10];

        public string this[int index]
        {
            get { return data[index]; }
            set { data[index] = value; }
        }
        //public static void Main()
        //{
        //    IndexeryNaSztywno indexeryNaSztywno = new IndexeryNaSztywno();
        //    indexeryNaSztywno[0] = "das";
        //    indexeryNaSztywno[1] = "faf";
        //}
    }
}
