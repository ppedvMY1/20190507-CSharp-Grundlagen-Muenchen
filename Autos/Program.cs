using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autos
{
    class Program
    {
        static void Main(string[] args)
        {
            // Auto Objekte erstellen
            PKW auto1 = new PKW("Rot", "M AV 123874", 20, 1899, 5);
            PKW auto2 = new PKW("Blau", "M TL 342", 20, 1899, 10);
            PKW auto3 = new PKW("Grün", "M XY 1294", 20, 1899, 3);

            // Ruft die überschriebene ToString() Methode auf und gibt sie in der Konsole aus
            Console.WriteLine($"Auto1: {auto1}");
            Console.WriteLine($"Auto2: {auto2}");
            Console.WriteLine($"Auto3: {auto3}");

            auto1.Farbe = "Silber";
            Console.WriteLine($"Auto1: {auto1}");

            Console.ReadKey();
        }
    }
}
