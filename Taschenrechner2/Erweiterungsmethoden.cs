using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taschenrechner2
{
    static class Erweiterungsmethoden
    {
        public static int Substract(this IEnumerable<int> source)
        {
            var result = source.First();
            for (int i = 1; i < source.Count(); i++)
            {
                result -= source.ToArray()[i];
            }
            return result;
        }
    }
}
