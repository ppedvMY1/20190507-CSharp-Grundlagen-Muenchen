using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestResultat
{
    class Program
    {
        static void Main(string[] args)
        {
            int eingegebeneZahl;

            // Die Schleife läuft so lange weiter, bis der Nutzer eine gültige Zahl eingegeben hat
            while(!int.TryParse(Console.ReadLine(), out eingegebeneZahl))
            {
                Console.WriteLine("Bitte gib eine Zahl ein: ");
            }

            if(eingegebeneZahl >= 7 && eingegebeneZahl <= 10)
            {
                Console.WriteLine("Der Test ist bestanden!");
            } else if (eingegebeneZahl < 7 && eingegebeneZahl >= 1)
            {
                Console.WriteLine("Der Test ist leider nicht bestanden!");
            } else
            {
                Console.WriteLine("Ungültige Eingabe");
            }

            Console.ReadKey();
        }
    }
}
