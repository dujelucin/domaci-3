using System;
using System.Collections.Generic;

namespace EvidencijaBolesnika
{
    public static class Admin
    {
        public static void Unos(List<Doktor> lstDoktori)
        {
            Console.Write("Unesi broj doktora: ");
            int br = int.Parse(Console.ReadLine());
            for (int i = 0; i < br; i++)
            {
                Doktor d = new Doktor();
                lstDoktori.Add(d);
            }
        }

        public static void Ispis(List<Doktor> lstDoktori)
        {
            foreach (Doktor d in lstDoktori)
                d.Ispis();
        }

        public static void NajteziBolesnikUkupno(List<Doktor> lstDoktori)
        {
            double max = 0;
            foreach (Doktor d in lstDoktori)
            {
                if (d.NajteziKodDoktora > max)
                    max = d.NajteziKodDoktora;
            }
            Console.WriteLine("Najteži bolesnik kod svih doktora ima {0} kg", max);
        }
    }
}