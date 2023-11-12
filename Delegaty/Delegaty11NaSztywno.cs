using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp48.Delegaty
{
    public delegate bool FilterDelegate(int number);
    public class Delegaty11NaSztywno
    {
        public bool IsEvent(int number)
        {
            return number % 2 == 0;
        }

        public bool IsPositive(int number)
        {
            return number > 0;
        }

        public List<int> FilterList(List<int> list, FilterDelegate filterMethod)
        {
            List<int> result = new List<int>();

            foreach (int item in list)
            {
                if (filterMethod(item))
                {
                    result.Add(item);
                }
            }
            return result;
        }

        //public static void Main()
        //{
        //    List<int> numbers = new List<int> { 1, 2, 3, 5, 6, 7, 8, 9, 0 };

        //    Delegaty11NaSztywno delegaty11NaSztywno = new Delegaty11NaSztywno();

        //    FilterDelegate filterDelegate = new FilterDelegate(delegaty11NaSztywno.IsEvent);
        //    List<int> eventNumber = delegaty11NaSztywno.FilterList(numbers, filterDelegate);

        //    Console.WriteLine("Liczby parzyste" + string.Join(",", eventNumber));


        //    FilterDelegate filterDelegate2 = new FilterDelegate(delegaty11NaSztywno.IsPositive);
        //    List<int> eventNumbers2 = delegaty11NaSztywno.FilterList(numbers, filterDelegate2);
        //    Console.WriteLine("Liczby dodatnie " + string.Join(",", eventNumbers2));

        //}
    }
}
