using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace ConsoleApp48.Delegaty
//{
//    public delegate bool Predicate<T>(T item);
//    internal class DelegatZMetodaAnonimowa3
//    {
//        delegate bool Predicate<T>(T item);

//        static void Main()
//        {
//            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

//            Predicate<int> isEven = delegate (int num) {
//                return num % 2 == 0;
//            };

//            List<int> evenNumbers = numbers.FindAll(isEven);

//            foreach (int num in evenNumbers)
//            {
//                Console.WriteLine(num);
//            }
//        }
//    }

