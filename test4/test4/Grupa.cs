using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test4
{
    class Grupa
    {
        static protected List<Persoana> grupa = new List<Persoana>();
        public void Adaugare_persoana()
        {
            Console.WriteLine("Ce doriti sa introduceti in grupa?");
            int z = int.Parse(Console.ReadLine());
            while (z != 0)
            {
                switch (z)
                {
                    case 1:
                        Console.WriteLine("Cati studenti introduceti in grupa");
                        int x = int.Parse(Console.ReadLine());
                        for (int cnt = 0; cnt < x; cnt++)
                        {
                            Console.WriteLine("Introdu un student");
                            Console.Write("Numele: ");
                            String nume = Console.ReadLine();
                            Console.Write("An studiu: ");
                            int an_studiu = int.Parse(Console.ReadLine());
                            Console.Write("Specializarea: ");
                            String specializare = Console.ReadLine();
                            Console.Write("Universitatea: ");
                            String universitate = Console.ReadLine();
                            Student stud = new Student(nume, an_studiu, specializare, universitate);
                            grupa.Add(stud);
                            Console.WriteLine("\n");
                        }
                        break;
                    case 2:
                        Console.WriteLine("Cati studenti introduceti in grupa");
                        x = int.Parse(Console.ReadLine());
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
                            grupa.Add(angaj);
                            Console.WriteLine("\n");
                        }
                        break;
                    default:
                        break;
                }
                Console.WriteLine("Ce doriti sa introduceti in grupa?");
                z = int.Parse(Console.ReadLine());
            }
        }
        public void Write3Console()
        {
            foreach (Persoana a in grupa)
            {
                Console.WriteLine(a.Afisare());
            }
        }
        public void setare_nota(String x)
        {
            IEnumerable<Persoana> interogare_linq =
                from grupa in grupa
                where grupa.Nume == x
                select grupa;
            foreach (Persoana a in interogare_linq)
            {
                Console.WriteLine(a.Afisare());
            }
        }
    }
}
