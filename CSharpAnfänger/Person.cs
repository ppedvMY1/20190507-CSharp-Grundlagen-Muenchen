using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAnfänger
{
    class Person
    {
        private string nachname;
        public string Nachname { get; } = "DEF";
        
        public Person()
        {
            Nachname = "ABC";
            ABC();
        }
        public void ABC()
        {
            Console.WriteLine(Nachname);
        }
    }
}
