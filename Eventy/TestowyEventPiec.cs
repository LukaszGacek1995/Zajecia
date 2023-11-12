using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Napisz program w języku C#, który symuluje stację pogodową. Stwórz klasę WeatherStation, 
//    która będzie zawierać zdarzenie TemperatureChanged informujące o zmianach temperatury. 
//    Klasa ta powinna mieć także właściwość CurrentTemperature reprezentującą aktualną temperaturę.
//    Gdy temperatura zostanie zmieniona, powinno to wywołać zdarzenie TemperatureChanged.

public delegate void DelegatZmianaTemperatury(int temperatura);

namespace ConsoleApp48.Eventy
{
    class Programaa
    {
        public class WeatherStation
        {
            public delegate void TemperatureChangeHandler(double newTemperature);
            public event TemperatureChangeHandler TemperatureChanged;

            private double currentTemperature;

            public double CurrentTemperature
            {
                get { return currentTemperature; }
                set
                {
                    if (value != currentTemperature)
                    {
                        currentTemperature = value;
                        OnTemperatureChanged(value);
                    }
                }
            }

            protected virtual void OnTemperatureChanged(double newTemperature)
            {
                TemperatureChanged?.Invoke(newTemperature);
            }
        }

        public static void TemperatureChangeHandlerMethod(double newTemperature)
        {
            Console.WriteLine($"Zmiana temperatury: {newTemperature}°C");
        }

        //static void Main(string[] args)
        //{
        //    WeatherStation weatherStation = new WeatherStation();
        //    weatherStation.TemperatureChanged += TemperatureChangeHandlerMethod;

        //    weatherStation.CurrentTemperature = 25.5;
        //    weatherStation.CurrentTemperature = 30.0;

        //    Console.ReadLine();
        //}
    }
}
