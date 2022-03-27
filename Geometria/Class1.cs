using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    public abstract class Bryla
    {
        private string nazwa;
        private double gestosc;
        private decimal cenaZaKg;
        public string Nazwa { get { return nazwa; } private set { nazwa = value; } }
        public double Gestosc { get { return gestosc; }private set { gestosc = value; } }
        public decimal CenaZaKg { get { return cenaZaKg; }private set { cenaZaKg = value; } }


        public abstract double ObliczObjetosc();
        public virtual double ObliczMase()
        {
         return 0.0;   
        }
        public decimal ObliczCene() 
        {
        return (decimal)ObliczMase() * CenaZaKg;
        }
        public Bryla(string n, double g, decimal c) {
            Nazwa= n;
            Gestosc= g;
            CenaZaKg = c;
        }
        public override string ToString() { 
        return $"{Nazwa}: Gestosc:{Gestosc}, Cena/Kg:{CenaZaKg} m:{ObliczMase()} Cena:{ObliczCene()} V:{ObliczObjetosc()}";
        }

    }
}
