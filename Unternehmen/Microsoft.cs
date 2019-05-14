using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unternehmen
{
    class Microsoft : IUnternehmen
    {
        public List<Mitarbeiter> Mitarbeiter { get; set; }
        public string[] Standorte { get; set; }

        public string JemandenEinstellen(string vorname, string name)
        {
            Random ran = new Random();
            if(ran.Next(0,3) == 0)
            {
                return $"{vorname} {name} wurde erfolgreich eingestellt!";
            }else
            {
                return $"{vorname} {name} wurde nicht eingestellt!";
            }
        }

        public void LoehneBezahlen()
        {
            throw new NotImplementedException();
        }

        public string UeberstundenAusbezahlen(string vorname, string name)
        {
            foreach (var mitarbeiter in Mitarbeiter)
            {
                if(mitarbeiter.Vorname == vorname && mitarbeiter.Name == name)
                {
                    return $"Die Überstunden für {vorname} {name} wurden ausbezahlt!";
                }else
                {
                    return $"{vorname} {name} wurde nicht gefunden";
                }
            }
            return "";
        }
    }
}
