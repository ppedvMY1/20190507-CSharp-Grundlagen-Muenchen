using System;
using System.Collections.Generic;

namespace Taschenrechner
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welche Rechenoperation möchtest du durchführen?");
            var operation = Console.ReadLine();


            var operanden = new List<int>();

            Console.WriteLine("Bitte gib die Operanden ein:");
            var eingabe = Console.ReadLine();

            var eingabeArray = eingabe.Split(',');

            foreach (var item in eingabeArray)
            {
                if(int.TryParse(item, out int res))
                {
                    operanden.Add(res);
                }
            }

            Rechner rechner = new Rechner(operation);
            Console.WriteLine("Das Ergebnis lautet:");
            Console.WriteLine(rechner.Rechne(operanden.ToArray()));

            Console.ReadKey();
        }
    }
}
