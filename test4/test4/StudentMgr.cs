using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test4
{
    class StudentMgr : PersoanaMgr
    {
        public void ReadStudent(int x)
        {
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
                if (elemente.Contains(stud) is false)
                    elemente.Add(stud);
                else Console.WriteLine("Acest serviciu a mai fost introdus!");
                Console.WriteLine("\n");
            }
        }

    }
}
