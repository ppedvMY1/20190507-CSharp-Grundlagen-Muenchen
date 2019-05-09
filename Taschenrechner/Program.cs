using System;

namespace Taschenrechner
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welche Rechenoperation möchtest du durchführen?");
            var operation = Console.ReadLine();

            Console.WriteLine("Bitte gib den ersten Operanden ein:");
            var op1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Bitte gib den zweiten Operanden ein:");
            var op2 = int.Parse(Console.ReadLine());

            Rechner rechner = new Rechner(operation);
            Console.WriteLine("Das Ergebnis lautet:");
            Console.WriteLine(rechner.Rechne(op1, op2));

            Console.ReadKey();
        }
    }
}
