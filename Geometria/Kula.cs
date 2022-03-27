using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    public class Kula: Bryla
    {
        public double Promien { get; set; }
        public override double ObliczObjetosc()
        {
            return Math.PI*(4.00/3.00)*Math.Pow(Promien,3);
        }
        public Kula(string nazwa, double gestosc, decimal cenaZaKilo, double promien) : base(nazwa, gestosc, cenaZaKilo)
        {
            Promien = promien;
        }


    }
}
