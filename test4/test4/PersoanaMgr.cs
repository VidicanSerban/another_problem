using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test4
{
    class PersoanaMgr
    {
        static protected List<Persoana> elemente = new List<Persoana>();

        public void Write2Console()
        {
            IEnumerable<Persoana> interogare_linq =
                from elemente in elemente
                select elemente;
            foreach (Persoana a in interogare_linq)
            {
                Console.WriteLine(a.Afisare());
            }
        }
    }
}
