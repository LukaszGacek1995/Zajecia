using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp48.Obiektowość
{
    public abstract class Ksiazka
    {
        private string tytul;
        private string autor;
        private int rok;
        private string identyfikator;

        public Ksiazka(string tytul, string autor, int rok, string identyfikator)
        {
            this.tytul = tytul;
            this.autor = autor;
            this.rok = rok;
            this.identyfikator = identyfikator;
        }

        public string Tytul { get { return tytul; } }
        public string Autor { get { return autor;} }
        public int Rok { get { return rok; } }
        public string Identyfikator { get { return identyfikator; } }

        public abstract void Informacje();
    }

    public class Powiesc: Ksiazka
    {
        public Powiesc(string tytul, string autor, int rok, string identyfikator) : base(tytul, autor,rok, identyfikator)
        {
            
        }
        public override void Informacje() 
        {
        
        }
   }
    public class Album
    {

    }

    public class Poradnik
    {

    }


    public class Bibliotek
    {

    }

    public class ProgramProgam
    {
        //public static void Main()
        //{

        //}
    }
}
