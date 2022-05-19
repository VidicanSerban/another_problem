using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ce doriti sa introduceti? 1-Student 2-Angajat 3-Afisare");
            int x = int.Parse(Console.ReadLine());
            StudentMgr mgrstudent = new StudentMgr();
            AngajatMgr mgrangajat = new AngajatMgr();
            Grupa grupa = new Grupa();
            while (x != 0)
            {
                switch (x)
                {
                    case 1:
                        Console.Write("Nr. studenti:");
                        int nrstudenti = int.Parse(Console.ReadLine());
                        mgrstudent.ReadStudent(nrstudenti);
                        break;
                    case 2:
                        Console.Write("Nr. angajati:");
                        int nrangajati = int.Parse(Console.ReadLine());
                        mgrangajat.ReadAngajat(nrangajati);
                        break;
                    case 3:
                        Console.Write("Afisare student/angajati: \n");
                        mgrstudent.Write2Console();
                        break;
                    case 4:
                        Console.Write("Adaugare grupa: \n");
                        grupa.Adaugare_persoana();
                        Console.Write("Afisare grupa: \n");
                        grupa.Write3Console();
                        break;
                    default:
                        Console.WriteLine("Ce doriti sa introduceti? 1-Student 2-Angajat 3-Afisare");
                        break;
                }
                Console.WriteLine("Ce doriti sa introduceti? 1-Student 2-Angajat 3-Afisare");
                x = int.Parse(Console.ReadLine());
            }
        }
    }
}
