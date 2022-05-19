using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test4
{
    public class Persoana
    {
        String nume;
        int nota;
        public string Nume { get => nume; set => nume = value; }
        public int Nota { get => nota; set => nota = value; }
        public Persoana(String nume)
        {
            this.Nume = nume;
        }
        public virtual String Afisare()
        {
            return "Nume: " + Nume;
        }
    }
}
