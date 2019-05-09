using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autos
{
    class PKW : Auto
    {
        public int Sitzplaetze { get; set; }
        public PKW(string farbe, string kennzeichen, int ps, int baujahr, int sitzplaetze) : base(farbe, kennzeichen, ps, baujahr)
        {
            Sitzplaetze = sitzplaetze;
        }

        public override string ToString()
        {
            return base.ToString() + $"\nAnzahl der Sitzplätze: {Sitzplaetze}";
        }
    }
}
