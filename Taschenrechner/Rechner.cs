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
                case "Addition":
                    {
                        rechenoperation = new Rechenoperation(Addiere);
                        break;
                    }
                case "Subtraktion":
                    {
                        rechenoperation = new Rechenoperation(delegate(int op1, int op2) {
                            return op1 - op2;
                        });
                        break;
                    }
                case "Multiplikation":
                    {
                        rechenoperation = delegate (int op1, int op2)
                        {
                            return op1 * op2;
                        };
                        break;
                    }
                case "Division":
                    {
                        rechenoperation = (op1, op2) =>
                        {
                            return op1 / op2;
                        };
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
    }
}
