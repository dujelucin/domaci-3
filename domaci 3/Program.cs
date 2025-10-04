using System;
using System.Collections.Generic;

namespace EvidencijaBolesnika
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Doktor> lstDoktori = new List<Doktor>();

            Admin.Unos(lstDoktori);
            Admin.Ispis(lstDoktori);
            Admin.NajteziBolesnikUkupno(lstDoktori);

            Console.ReadKey();
        }
    }
}