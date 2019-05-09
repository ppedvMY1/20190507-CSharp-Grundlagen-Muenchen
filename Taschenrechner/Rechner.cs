using System;
using System.Collections.Generic;
using System.Text;

namespace Taschenrechner
{
    class Rechner
    {
        string Operation { get; set; }
        public Rechner(string operation)
        {
            this.Operation = operation;
        }
        public int Rechne(int op1, int op2)
        {
            switch(Operation)
            {
                case "Addieren":
                    {
                        return Addiere(op1, op2);
                    }
                case "Subtrahieren":
                    {
                        return Subtrahiere(op1, op2);
                    }
                default:
                    {
                        return int.MinValue;
                    }
            }
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
