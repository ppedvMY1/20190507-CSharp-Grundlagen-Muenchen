﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Taschenrechner2
{
    class Rechner
    {
        public delegate int Rechenoperation(params int[] operanden);
        Rechenoperation rechenoperation;

        public Rechner(string operation)
        {
            switch(operation)
            {
                case "Addition":
                    {
                        rechenoperation = x => x.Aggregate((y, z) => y + z);
                        break;
                    }
                case "Subtraktion":
                    {
                        rechenoperation = x => x.Substract();
                        break;
                    }
                /*case "Multiplikation":
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
                case "Modulo":
                    {
                        rechenoperation = (x, y) => x % y;
                        break;
                    }*/
                default:
                    {
                        return;
                    }
            }
        }
        /// <summary>
        /// Führt die im Konstruktor gesetzte Rechenoperation aus.
        /// </summary>
        /// <param name="operanden">Eine Liste von Operanden.</param>
        /// <returns></returns>
        public int Rechne(params int[] operanden)
        {
            return rechenoperation(operanden);
        }

        public int Addiere(params int[] operanden)
        {
            return operanden.Aggregate((x, y) => x + y);
        }
    }
}
