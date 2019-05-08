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
            Auto auto1 = new Auto("Rot", "M AV 123874", 20, 1899);
            Auto auto2 = new Auto("Blau", "M TL 342", 20, 1899);
            Auto auto3 = new Auto("Grün", "M XY 1294", 20, 1899);

            // Ruft die überschriebene ToString() Methode auf und gibt sie in der Konsole aus
            Console.WriteLine($"Auto1: {auto1}");
            Console.WriteLine($"Auto2: {auto2}");
            Console.WriteLine($"Auto3: {auto3}");

            auto1.Farbe = "Silber";
            Console.WriteLine($"Auto1: {auto1}");

            Console.ReadKey();
            System.Threading.Thread.Sleep(1000);
        }
    }
}
