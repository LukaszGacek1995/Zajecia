using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp48.Spoj_Zadanie_Srednie.Światelka.ModyfikacjeZadania
{
    public class MODIDataInput
    {
        public int n { get; set; }
        public int m { get; set; }
        public List<Tuple<int, int>> polaczenie { get; set; }

        public MODIDataInput(MODWartosciWprowadzone.TestInput input)
        {
            this.n = input.n;
            this.m = input.m;
            this.polaczenie = this.polaczenie;

        }
    }
}
