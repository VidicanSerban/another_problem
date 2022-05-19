using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test4
{
    public class Angajat : Persoana
    {
        String companie;
        String pozitie;
        public string Companie { get => companie; set => companie = value; }
        public string Pozitie { get => pozitie; set => pozitie = value; }
        public Angajat(string nume, String companie, String pozitie)
            : base(nume)
        {
            this.Companie = companie;
            this.Pozitie = pozitie;
        }
        public override String Afisare()
        {
            return "Angajatul " + base.Afisare() + " de la compania " + Companie + ", de pe pozitia " + Pozitie;
        }
    }
}
