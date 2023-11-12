using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp48.Spoj_Zadanie_Srednie.Konferencja
{
    public interface IPrzekazywanie
    {
        int PobierzCzwartylementy();
        int PobierxDrugielement();
        List<int> PrzekazanieWartosciDoKlasyKtoraBedzieObliczala();
    }
}
