using FupLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestFupLib
{
    [TestClass]
    public class UnitTestFup1
    {
        [TestMethod]
        public void FupAverage()
        {

            TransportCalc.Average(1500, 7.05);

        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void FupAverageException()
        {
            
            TransportCalc.Average(1500, 100);
        }
    }
}
