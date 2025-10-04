using System;
using System.Collections.Generic;

namespace EvidencijaBolesnika
{
    public class Doktor : Osoba
    {
        string _odjel;
        double _placa;
        List<Bolesnik> lstBolesnici = new List<Bolesnik>();

        public Doktor()
        {
            Console.Write("Unesi ime doktora: ");
            Ime = Console.ReadLine();

            Console.Write("Unesi prezime doktora: ");
            Prezime = Console.ReadLine();

            Console.Write("Unesi datum rođenja doktora (dd.MM.yyyy): ");
            DatumRodjenja = DateTime.Parse(Console.ReadLine());

            Console.Write("Unesi matični broj doktora: ");
            MaticniBroj = Console.ReadLine();

            Console.Write("Unesi odjel: ");
            _odjel = Console.ReadLine();

            Console.Write("Unesi iznos plaće: ");
            _placa = double.Parse(Console.ReadLine());

            Console.Write("Unesi broj bolesnika: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Bolesnik b = new Bolesnik();
                lstBolesnici.Add(b);
            }
        }

        public void NoviBolesnik()
        {
            Bolesnik b = new Bolesnik();
            lstBolesnici.Add(b);
        }

        public void ObrisiBolesnika()
        {
            Console.Write("Unesi matični broj bolesnika za brisanje: ");
            string mb = Console.ReadLine();
            Bolesnik trazeni = null;

            foreach (Bolesnik b in lstBolesnici)
            {
                if (b.MaticniBroj == mb)
                {
                    trazeni = b;
                    break;
                }
            }

            if (trazeni == null)
                Console.WriteLine("Bolesnik nije pronađen.");
            else
            {
                lstBolesnici.Remove(trazeni);
                Console.WriteLine("Bolesnik uspješno obrisan.");
            }
        }

        public double NajteziBolesnik()
        {
            double max = 0;
            foreach (Bolesnik b in lstBolesnici)
            {
                if (b.Tezina > max)
                    max = b.Tezina;
            }
            return max;
        }

        public double ProsjecnaVisina()
        {
            if (lstBolesnici.Count == 0) return 0;

            double suma = 0;
            foreach (Bolesnik b in lstBolesnici)
                suma += b.Visina;

            return suma / lstBolesnici.Count;
        }

        public void NajmladjiUOdnosuNaProsjek()
        {
            if (lstBolesnici.Count == 0)
            {
                Console.WriteLine("Nema bolesnika.");
                return;
            }

            double suma = 0;
            foreach (Bolesnik b in lstBolesnici)
                suma += (DateTime.Now - b.DatumRodjenja).TotalDays;

            double prosjekDana = suma / lstBolesnici.Count;

            Bolesnik najmladji = lstBolesnici[0];
            foreach (Bolesnik b in lstBolesnici)
            {
                if (b.DatumRodjenja > najmladji.DatumRodjenja)
                    najmladji = b;
            }

            double razlikaGodina = (prosjekDana - (DateTime.Now - najmladji.DatumRodjenja).TotalDays) / 365;
            Console.WriteLine("Najmlađa osoba mlađa je od prosjeka za: {0:F1} godina", razlikaGodina);
        }

        public void Ispis()
        {
            Console.WriteLine("Doktor: {0} {1}, Odjel: {2}, Plaća: {3}", Ime, Prezime, _odjel, _placa);
            foreach (Bolesnik b in lstBolesnici)
                b.Ispis();
        }

        public double NajteziKodDoktora
        {
            get { return NajteziBolesnik(); }
        }
    }
}