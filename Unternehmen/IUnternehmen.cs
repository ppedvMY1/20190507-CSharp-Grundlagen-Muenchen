using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unternehmen
{
    interface IUnternehmen
    {
        List<Mitarbeiter> Mitarbeiter { get; set; }
        void LoehneBezahlen();
        string JemandenEinstellen(string vorname, string name);
        string UeberstundenAusbezahlen(string vorname, string name);
        string[] Standorte { get; set; }
    }
}
