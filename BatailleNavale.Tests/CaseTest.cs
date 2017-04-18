using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BatailleNavale;

namespace BatailleNavale.Tests
{
    [TestClass]
    class CaseTest
    {
         
        [TestMethod]
        public void basicTest()
        {
            Case c = new Case();

            Assert.Equals(1,1);

        }
    }
}
