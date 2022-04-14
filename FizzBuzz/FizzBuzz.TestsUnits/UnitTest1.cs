using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzz.TestsUnits
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void siNombreMultipleDe3()
        {
            int nombre = 2;

            if(nombre % 3 != 0)
                Assert.Fail();
        }

        public void siNombreMultipleDe5()
        {
            int nombre = 2;

            if (nombre % 5 != 0)
                Assert.Fail();
        }

        public void siNombreMultipleDe3et5()
        {
            int nombre = 2;

            if (nombre % 3 != 0 | nombre % 5 != 0)
                Assert.Fail();
        }

        public void siNombreEgale3()
        {
        }

        public void siNombreEgale5()
        {
        }

        public void siNombreEgale3et5()
        {
        }
    }
}
