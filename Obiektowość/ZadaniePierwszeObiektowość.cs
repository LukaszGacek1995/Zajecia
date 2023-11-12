using ConsoleApp48.Obiektowość.Interface;
using ConsoleApp48.Spoj_Zadania_Łatwe;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp48.Obiektowość
{
    public abstract class ZadaniePierwszeObiektowość : IPojazd
    {
        protected string marka;
        protected string model;

        public ZadaniePierwszeObiektowość(string Model, string Marka)
        {
            this.marka = Marka;
            this.model = Model;
        }
        public abstract void Start();

        public abstract void Stop();

        public override string ToString()
        {
            return $"Mark samochodu {marka} oraz model {model}";
        }
    }

    public class Samochod : ZadaniePierwszeObiektowość
    {

        public Samochod(string marka, string model) : base(marka, model)
        {

        }
        public override void Start()
        {
            Console.WriteLine("Uruchom silnik samochodu");
        }

        public override void Stop()
        {
            Console.WriteLine("Zatrzymaj silnik samochodu");
        }
    }

    public class Motocykl : ZadaniePierwszeObiektowość
    {
        public Motocykl(string model, string marka) : base(model, marka)
        {

        }
        public override void Start()
        {
            Console.WriteLine("elo");
        }

        public override void Stop()
        {
            throw new NotImplementedException("Wyjateczek");
        }
    }

    public class OdpalanieProgramu
    {
        //public static void Main()
        //{
        //    List<IPojazd> pojazd = new List<IPojazd>()
        //    {
        //        new Samochod("Audi", "Mercedes"),
        //        new Motocykl("Bmw", "Ktm")
        //    };

        //    foreach(var poj in pojazd)
        //    {
        //        Console.WriteLine(pojazd.ToString());
        //        poj.Start();
        //        poj.Stop();
        //    }
        //}
    }
}

