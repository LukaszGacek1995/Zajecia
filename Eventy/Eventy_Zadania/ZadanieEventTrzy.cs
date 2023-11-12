using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp48.Eventy.Eventy_Zadania
{
    public class ZadanieEventTrzy
    {
        //public static void Main()
        //{
        //    Osoba osoba = new Osoba();
        //    osoba.PropertyChanged += OsobaZmianaHandler;

        //    osoba.Name = "Anna";
        //    osoba.Wiek = 30;


        //    osoba.Name = "Jan";
        //    osoba.Wiek = 32;

        //}
        public static void OsobaZmianaHandler(object sender, PropertyChangedEventArgs e)
        {
            Console.WriteLine($"Zmiana wartości {e.PropertyName}");
        }
    }

    public class Osoba : INotifyPropertyChanged
    {
        private string name;
        private int wiek;

        public event PropertyChangedEventHandler PropertyChanged;

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (value != this.name)
                {
                    this.name = value;
                    OsobapropertyName("Imie");
                }

            }

        }

        public int Wiek
        {
            get
            {
                return this.wiek;
            }
            set
            {
                if (value != wiek)
                {
                    wiek = value;
                    OsobapropertyName("wiek");
                }
            }
        }

        protected virtual void OsobapropertyName(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
