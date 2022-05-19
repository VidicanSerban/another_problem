using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test4
{
    class AngajatMgr : PersoanaMgr
    {
        public void ReadAngajat(int x)
        {
            for (int cnt = 0; cnt < x; cnt++)
            {
                Console.WriteLine("Introdu un student");
                Console.Write("Numele: ");
                String nume = Console.ReadLine();
                Console.Write("Compania: ");
                String companie = Console.ReadLine();
                Console.Write("Pozitia: ");
                String pozitie = Console.ReadLine();
                Angajat angaj = new Angajat(nume, companie, pozitie);
                if (elemente.Contains(angaj) is false)
                    elemente.Add(angaj);
                else Console.WriteLine("Acest serviciu a mai fost introdus!");
                Console.WriteLine("\n");
            }
        }

    }
}
