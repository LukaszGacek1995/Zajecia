using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp48.Delegaty
{
    public delegate int ComparisonDelegate(int x, int y);
    public class DeleagtyIZdarzeniaNaSztywno
    {

        public  int CompareAscending(int x, int y)
        {
            return x.CompareTo(y);
        }

        public  int CompareDescending(int x , int y)
        {
            return y.CompareTo(x);
        }

        public void SortArray(int[] arr, ComparisonDelegate comparisonMethod )
        {
            for(int i =0; i <arr.Length -1; i++)
            {
                for(int j = i+1; j< arr.Length; j++)
                {
                 if (comparisonMethod(arr[i], arr[j])>0)
                 {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                 }
                }
            }
        }

        //public static void Main()
        //{
        //    DeleagtyIZdarzeniaNaSztywno deleagtyIZdarzeniaNaSztywno = new DeleagtyIZdarzeniaNaSztywno();

        //    int[] numbers = { 5, 4, 3, 3, 5, 2, 1 };


        //    deleagtyIZdarzeniaNaSztywno.SortArray(numbers, deleagtyIZdarzeniaNaSztywno.CompareAscending);
        //    Console.WriteLine("tablica prze posortowaniem rosnącym" + string.Join(",", numbers));

        //    deleagtyIZdarzeniaNaSztywno.SortArray(numbers, deleagtyIZdarzeniaNaSztywno.CompareDescending);
        //    Console.WriteLine("tablica po sortowaniu malejącym" + string.Join(",", numbers));


        //}
    }
}
