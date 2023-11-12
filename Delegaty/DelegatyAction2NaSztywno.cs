using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp48.Delegaty
{
    delegate void ComplexDle(string message);
    public class DelegatyAction2NaSztywno
    {
        static void MethodA(string message)
        {
            Console.WriteLine($"MethodA: {message}");
        }
        static void MethodB(string message)
        {
            Console.WriteLine($"MethodB: {message}");
        }


        //public static void Main()
        //{
        //    ComplexDle complexDle = new ComplexDle(MethodA);
        //    complexDle += MethodB;
        //     complexDle("Elo mordoo");


        //   complexDle -= MethodA;
        //    complexDle("dsasd");
        //}
    }
}
