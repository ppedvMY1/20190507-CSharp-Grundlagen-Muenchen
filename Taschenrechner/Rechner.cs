using System;
using System.Collections.Generic;
using System.Text;

namespace Taschenrechner
{
    class Rechner
    {
        public delegate int Rechenoperation(int op1, int op2);
        Rechenoperation rechenoperation;

        public Rechner(string operation)
        {
            switch(operation)
            {
                case "Addieren":
                    {
                        rechenoperation = new Rechenoperation(Addiere);
                        break;
                    }
                case "Subtrahieren":
                    {
                        rechenoperation = new Rechenoperation(Subtrahiere);
                        break;
                    }
                default:
                    {
                        return;
                    }
            }
        }
        public int Rechne(int op1, int op2)
        {
            return rechenoperation(op1, op2);
        }

        public int Addiere(int op1, int op2)
        {
            return op1 + op2;
        }
        public int Subtrahiere(int op1, int op2)
        {
            return op1 - op2;
        }
    }
}
