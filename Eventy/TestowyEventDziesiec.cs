using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp48.Eventy
{
    public class TestowyEventDziesiec
    {
        private int count;
        private int Threshold { get; set; }

        public event EventHandler ThresholdReached;

        public TestowyEventDziesiec( int threshold)
        {
            this.Threshold = threshold;
        }   

        public void Eloszka()
        {
            count++;
            Console.WriteLine($"Aktualana wartość liczników {count}");

            if(count >=Threshold)
            {
                OnThresholdReached(EventArgs.Empty);
            }
        }


        public virtual void OnThresholdReached(EventArgs e)
        {
            ThresholdReached?.Invoke(this, e);
        }
    }

    public class KalsaZMechanizmemDzialania
    {
        //public static void Main()
        //{
        //    TestowyEventDziesiec testowyEventDziesiec = new TestowyEventDziesiec(3);
        //    testowyEventDziesiec.ThresholdReached += ThresholdReachedHandler;

        //    testowyEventDziesiec.Eloszka();
        //    testowyEventDziesiec.Eloszka();
        //    testowyEventDziesiec.Eloszka();

        //    Console.ReadKey();

        //}
        public static void ThresholdReachedHandler(object sender, EventArgs e)
        {
            Console.WriteLine("Próg został osiągnięty");
        }
    }
}
