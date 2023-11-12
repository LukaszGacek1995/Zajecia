using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp48.Delegaty
{
    internal class Delegat10NaSztywno
    {
        public delegate double MathOperation(double x, double y);
        static double Add(double x, double y)
        {
            return x + y;
        }

        static double Subtract(double x, double y)
        {
            return x - y;
        }

        static double Multiply(double x, double y)
        {
            return x * y;
        }

        static double Divide(double x, double y)
        {
            if (y != 0)
                return x / y;
            else
                throw new DivideByZeroException("Nie można dzielić przez zero.");
        }

        //public static void Main()
        //{
        //    MathOperation addDelegate = Add;
        //    Console.WriteLine("Wynik dodawania: " + addDelegate(5, 3));

        //    MathOperation subtractDelegate = Subtract;
        //    Console.WriteLine("Wynik odejmowania: " + subtractDelegate(8, 4));

        //    MathOperation multiplyDelegate = Multiply;
        //    Console.WriteLine("Wynik mnożenia: " + multiplyDelegate(6, 2));

        //    MathOperation divideDelegate = Divide;
        //    try
        //    {
        //        Console.WriteLine("Wynik dzielenia: " + divideDelegate(10, 2));
        //    }
        //    catch (DivideByZeroException ex)
        //    {
        //        Console.WriteLine("Błąd: " + ex.Message);
        //    }
        //}
    }
}
