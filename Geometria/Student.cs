using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    public class Student:IWyswietl
    {
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public Student(string imie, string nazwisko) { 
        Imie = imie;
            Nazwisko = nazwisko;
        }
        public string PobierzIdentyfikator()
        {
            return Imie + Nazwisko;
        }
        public override string ToString()
        {
            return PobierzIdentyfikator();
        }

    }
}
