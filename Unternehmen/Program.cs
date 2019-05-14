using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unternehmen
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IUnternehmen> unternehmen = new List<IUnternehmen>();
            Audi audi = new Audi();
            audi.Mitarbeiter.Add(new Mitarbeiter("Max", "Mustermann"));
            Bosh bosh = new Bosh();
            unternehmen.Add(audi);
            unternehmen.Add(bosh);

            foreach (var u in unternehmen)
            {
                u.Mitarbeiter.Add(new Mitarbeiter("Tom", "Müller"));
                u.Mitarbeiter.Add(new Mitarbeiter("Hanna", "Musterfrau"));
            }

            try
            {
                MacheGeschaefte(audi);

                for (int i = 0; i < 1000000; i++)
                {
                    Audi a = new Audi();
                }


                GC.Collect();
                GC.WaitForFullGCComplete();
                MacheGeschaefte(bosh);
            }catch(Exception e)
            {
                return;
            }
            Console.ReadKey();
        }

        static void MacheGeschaefte(IUnternehmen unternehmen)
        {
            Console.WriteLine(unternehmen.JemandenEinstellen("Max", "Mustermann"));
            Console.WriteLine(unternehmen.JemandenEinstellen("Christine", "Müller"));
            Console.WriteLine( unternehmen.UeberstundenAusbezahlen("Max", "Mustermann"));
            Console.WriteLine( unternehmen.UeberstundenAusbezahlen("Christine", "Müller"));
        }
    }
}
