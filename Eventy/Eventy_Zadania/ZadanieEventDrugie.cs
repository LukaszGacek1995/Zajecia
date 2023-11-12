using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp48.Eventy.Eventy_Zadania
{

      //Zadanie: Aplikacja do monitorowania stanu baterii

      // W tym zadaniu stworzymy prostą aplikację, która monitoruje stan baterii 
      //  urządzenia i powiadamia użytkownika o zmianach w stanie baterii.
    public class ZadanieEventDrugie
    {
        //public static void Main()
        //{
        //    Bateria bateria = new Bateria();
        //    MonitorBaterii monitorBaterii = new MonitorBaterii();

        //    monitorBaterii.RozpoczecieMonitorowania(bateria);

        //    bateria.BiezacyStan = StanBateria.Ładowanie;
        //    bateria.BiezacyStan = StanBateria.Pełny;
        //    bateria.BiezacyStan = StanBateria.Rozładowanie;

        //    monitorBaterii.ZakonczenieMonitorowania(bateria);

        //    Console.ReadLine();
        //}
    }

    public class ZmianaStanuBaterii : EventArgs
    {

        public StanBateria StaryStan { get; }
        public StanBateria NowyStan { get; }

        public ZmianaStanuBaterii(StanBateria staryStan, StanBateria nowyStan)
        {
            StaryStan = staryStan;
            NowyStan = nowyStan;
        }
    }

    public enum StanBateria
    {
        Ładowanie, 
        Rozładowanie, 
        Pełny, 
        Pusty

    }

    public class Bateria
    {

        private StanBateria biezacyStan;

        public event EventHandler<ZmianaStanuBaterii> StanZmiany;

        public StanBateria BiezacyStan
        {
            get
            {
                return biezacyStan;
            }
            set
            {
                StanBateria staryStan = biezacyStan;
                biezacyStan = value;

                if(staryStan != biezacyStan)
                {
                    StanZmieniony(staryStan, biezacyStan);
                }
            }
        }


        protected virtual void StanZmieniony(StanBateria staryStan, StanBateria nowyStan)
        {
            StanZmiany?.Invoke(this, new ZmianaStanuBaterii(staryStan, nowyStan));
        }
    }

    public class MonitorBaterii
    {
        public void RozpoczecieMonitorowania(Bateria bateria)
        {
            bateria.StanZmiany += OsluzenieZmianyStanuBaterii;
        }

        public void ZakonczenieMonitorowania(Bateria bateria)
        {
            bateria.StanZmiany -= OsluzenieZmianyStanuBaterii;
        }
        private void OsluzenieZmianyStanuBaterii(object sender, ZmianaStanuBaterii e )
        {
            Console.WriteLine($" Zmiana stanu baterri z {e.StaryStan}");
        }

    }

}
