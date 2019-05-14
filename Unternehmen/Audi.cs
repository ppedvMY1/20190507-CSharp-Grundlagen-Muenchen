using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unternehmen
{
    class Audi : IUnternehmen
    {
        ~Audi()
        {
            throw new Exception();
        }

        public List<Mitarbeiter> Mitarbeiter { get; set; } = new List<Mitarbeiter>();
        public string[] Standorte { get; set; }

        public string JemandenEinstellen(string vorname, string name)
        {
            Console.WriteLine(GetType().Name);

            Random ran = new Random();
            if(ran.Next(0,2) == 0)
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
            Console.WriteLine(GetType().Name);

            var mitarbeiter = Mitarbeiter.Where(x => x.Vorname == vorname && x.Name == name).FirstOrDefault();
      
            if (mitarbeiter != null)
            {
                return $"Die Überstunden für {mitarbeiter.Vorname} {mitarbeiter.Name} wurden ausbezahlt!";
            } else
            {
                return $"{vorname} {name} wurde nicht gefunden";

            }

            return "";
        }
    }
}
