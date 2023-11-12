using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp48.Obiektowość.Interface
{
    public interface IBiblioteka
    {
        void DodajKsiazke(Ksiazka ksiazka);
        void UsunKsiazke(string identyfikator);
        void WyswietlWszystkieKsiazki();
    }
}
