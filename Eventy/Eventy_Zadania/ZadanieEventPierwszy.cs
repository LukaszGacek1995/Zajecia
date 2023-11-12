using ConsoleApp48;
using ConsoleApp48.Eventy.Eventy_Zadania;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace ConsoleApp48.Eventy.Eventy_Zadania
{
    public class ZmianaTemperaturyEventArgs : EventArgs
    {
        public double StaraTemperatura { get; }
        public double NowaTemperatura { get; }

        public ZmianaTemperaturyEventArgs(double staraTemperatura, double nowaTemperatura)
        {
            StaraTemperatura = staraTemperatura;
            NowaTemperatura = nowaTemperatura;
        }
    }

    // Klasa reprezentująca czujnik temperatury
    public class CzujnikTemperatury
    {
        private double bieżącaTemperatura;

        public event EventHandler<ZmianaTemperaturyEventArgs> TemperaturaZmieniona;

        public double BieżącaTemperatura
        {
            get { return bieżącaTemperatura; }
            set
            {
                double staraTemperatura = bieżącaTemperatura;
                bieżącaTemperatura = value;

                // Sprawdzenie, czy temperatura się zmieniła
                if (staraTemperatura != bieżącaTemperatura)
                {
                    OnTemperaturaZmieniona(staraTemperatura, bieżącaTemperatura);
                }
            }
        }

        protected virtual void OnTemperaturaZmieniona(double staraTemperatura, double nowaTemperatura)
        {
            TemperaturaZmieniona?.Invoke(this, new ZmianaTemperaturyEventArgs(staraTemperatura, nowaTemperatura));
        }
    }

    // Klasa reprezentująca monitor temperatury
    public class MonitorTemperatury
    {
        public void RozpocznijMonitorowanie(CzujnikTemperatury czujnik)
        {
            czujnik.TemperaturaZmieniona += ObsłużZmianeTemperatury;
        }

        public void ZakończMonitorowanie(CzujnikTemperatury czujnik)
        {
            czujnik.TemperaturaZmieniona -= ObsłużZmianeTemperatury;
        }

        private void ObsłużZmianeTemperatury(object sender, ZmianaTemperaturyEventArgs e)
        {
            Console.WriteLine($"Zmiana temperatury: {e.StaraTemperatura}°C -> {e.NowaTemperatura}°C");
        }
    }

    // Klasa główna aplikacji
    class Program
    {
        //static void Main()
        //{
        //    CzujnikTemperatury czujnik = new CzujnikTemperatury();
        //    MonitorTemperatury monitor = new MonitorTemperatury();

        //    // Rozpoczęcie monitorowania temperatury
        //    monitor.RozpocznijMonitorowanie(czujnik);

        //    // Symulacja zmiany temperatury
        //    czujnik.BieżącaTemperatura = 25.0;
        //    czujnik.BieżącaTemperatura = 26.5;
        //    czujnik.BieżącaTemperatura = 24.8;

        //    // Zakończenie monitorowania temperatury
        //    monitor.ZakończMonitorowanie(czujnik);

        //    Console.ReadLine();
        //}
    }
}



