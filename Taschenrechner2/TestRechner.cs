using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Taschenrechner2
{
    [TestClass]
    public class TestRechner
    {
        [TestMethod]
        public void TestAddition()
        {
            Rechner rechner = new Rechner("Addition");
            var ergebnis = rechner.Rechne(2, 3);
            Assert.AreEqual(5, ergebnis);

            ergebnis = rechner.Rechne(99, 2, 3, 10, 99, 12, -1);
            Assert.AreEqual(224, ergebnis);

            rechner.Rechne()
            ergebnis = rechner.Rechne(99, 2, 3, 10, 99, int.MinValue, -1);
            Assert.AreEqual(224, ergebnis);

            
        }
    }
}
