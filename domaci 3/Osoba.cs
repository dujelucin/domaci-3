using System;

namespace EvidencijaBolesnika
{
    public class Osoba
    {
        string _ime, _prezime, _maticniBroj;
        DateTime _datumRodjenja;

        public string Ime { get { return _ime; } set { _ime = value; } }
        public string Prezime { get { return _prezime; } set { _prezime = value; } }
        public string MaticniBroj { get { return _maticniBroj; } set { _maticniBroj = value; } }
        public DateTime DatumRodjenja { get { return _datumRodjenja; } set { _datumRodjenja = value; } }
    }
}