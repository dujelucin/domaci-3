using System;

namespace EvidencijaBolesnika
{
    public class Bolesnik : Osoba
    {
        DateTime _datumPrijema;
        double _visina, _tezina;

        public Bolesnik()
        {
            Console.Write("Unesi ime bolesnika: ");
            Ime = Console.ReadLine();

            Console.Write("Unesi prezime bolesnika: ");
            Prezime = Console.ReadLine();

            Console.Write("Unesi datum rođenja (dd.MM.yyyy): ");
            DatumRodjenja = DateTime.Parse(Console.ReadLine());

            Console.Write("Unesi matični broj: ");
            MaticniBroj = Console.ReadLine();

            Console.Write("Unesi datum prijema u bolnicu (dd.MM.yyyy): ");
            _datumPrijema = DateTime.Parse(Console.ReadLine());

            Console.Write("Unesi visinu (u cm): ");
            _visina = double.Parse(Console.ReadLine());

            Console.Write("Unesi težinu (u kg): ");
            _tezina = double.Parse(Console.ReadLine());
        }

        public double Tezina { get { return _tezina; } }
        public double Visina { get { return _visina; } }

        public void Ispis()
        {
            Console.WriteLine("{0} {1}, JMBG: {2}, Rođen: {3:d}, Težina: {4} kg, Visina: {5} cm",
                Ime, Prezime, MaticniBroj, DatumRodjenja, _tezina, _visina);
        }
    }
}