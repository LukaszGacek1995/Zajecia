using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 namespace ConsoleApp48.Eventy
{
    public delegate void TemperatureChangeHandler(double newTemperature);

    // On jest publisherem czyli generuje zdarzenia
    public class Thermostat
    {
        // Krok 2: Definicja eventu przy użyciu delegata
        public event TemperatureChangeHandler TemperatureChanged;

        private double temperature;

        public double Temperature
        {
            get { return temperature; }
            set
            {
                if (value != temperature)
                {
                    temperature = value;

                    // Krok 5: Wywołanie zdarzenia, informujące o zmianie temperatury
                    OnTemperatureChanged(value);
                }
            }
        }

        // Krok 5: Metoda do wywołania zdarzenia
        protected virtual void OnTemperatureChanged(double newTemperature)
        {
            TemperatureChanged?.Invoke(newTemperature);
        }
    }

    public class Heater
    {
        // Krok 3: Metoda obsługi (handler)
        public void HeaterTemperatureChanged(double newTemperature)
        {
            Console.WriteLine($"Heater: Temperature changed to {newTemperature}");
        }
    }

    public class AirConditioner
    {
        // Krok 3: Metoda obsługi (handler)
        public void AirConditionerTemperatureChanged(double newTemperature)
        {
            Console.WriteLine($"Air Conditioner: Temperature changed to {newTemperature}");
        }
    }

    class Program
    {
        //static void Main(string[] args)
        //{
        //    Thermostat thermostat = new Thermostat();
        //    Heater heater = new Heater();
        //    AirConditioner airConditioner = new AirConditioner();

        //    // Krok 4: Subskrypcja eventu przez metody obsługi
        //    thermostat.TemperatureChanged += heater.HeaterTemperatureChanged;
        //    thermostat.TemperatureChanged += airConditioner.AirConditionerTemperatureChanged;

        //    thermostat.Temperature = 25.0; // Wywoła obsługę eventu w obiektach heater i airConditioner
        //}
    }
}
