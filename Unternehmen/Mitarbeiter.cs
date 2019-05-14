using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unternehmen
{
    class Mitarbeiter
    {
        public Mitarbeiter(string vorname, string name)
        {
            Vorname = vorname;
            Name = name;
        }

        public string Vorname { get; set; }
        public string Name { get; set; }
    }
}
