using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autos
{
    class Auto
    {
        // Eigenschaften und Felder
        private string farbe;
        public string Farbe {
            get
            {
                return farbe;
            }
            set
            {
                // Der eingegebene String muss im Autofarben enum vorhanden sein, ansonsten werfe eine Exception
                if(Enum.TryParse<Autofarben>(value, out Autofarben auto))
                {
                    farbe = value;
                } else
                {
                    throw new Exception();
                }
            }
        }
        public enum Autofarben
        {
            Rot,
            Blau,
            Schwarz,
            Weiß,
            Silber,
            Grün
        }
        private string kennzeichen;
        public string Kennzeichen
        {
            get
            {
                return kennzeichen;
            }
            set
            {
                if (value.Length > 2)
                {
                    kennzeichen = value;
                }else
                {
                    throw new Exception();
                }
            }
        }
        private int ps;
        public int Ps
        {
            get
            {
                return ps;
            }
            set
            {
                if (value > 0 && value <= 1500)
                {
                    ps = value;
                }else
                {
                    throw new Exception();
                }
            }
        }
        private int baujahr;
        public int Baujahr
        {
            get
            {
                return baujahr;
            }
            set
            {
                if (value >= 1885 && value <= System.DateTime.Now.Year)
                {
                    baujahr = value;
                } else
                {
                    throw new Exception();
                }
            }
        }

        public Auto(string farbe, string kennzeichen, int ps, int baujahr)
        {
            Farbe = farbe;
            Kennzeichen = kennzeichen;
            Ps = ps;
            Baujahr = baujahr;
        }

        //ToString von Object überschreiben, damit wir eine bessere Ausgabe erhalten
        public override string ToString()
        {
            return $"Das Auto hat die Farbe {this.Farbe} und das Kennzeichen {this.Kennzeichen}, hat {this.Ps} PS und wurde im Jahr {this.Baujahr} gebaut";
        }

    }
}
