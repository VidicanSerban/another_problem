using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test4
{
    public class Student : Persoana
    {
        int an_studiu;
        String specializare;
        String universitate;

        public int An_studiu { get => an_studiu; set => an_studiu = value; }
        public string Specializare { get => specializare; set => specializare = value; }
        public string Universitate { get => universitate; set => universitate = value; }
        public Student(string nume, int an_studiu, String specializare, String universitate)
            : base(nume)
        {
            this.An_studiu = an_studiu;
            this.Specializare = specializare;
            this.Universitate = universitate;
        }

        public override String Afisare()
        {
            return "Studentul " + base.Afisare() + " din anul " + An_studiu+", de la specializarea "+Specializare+", de la universitatea "+Universitate;
        }
    }
}
