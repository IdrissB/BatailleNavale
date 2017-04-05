using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BatailleNavale;

namespace BatailleNavale.Tests
{
    [TestClass]
    public class BateauTest
    {
        [TestMethod]
        public void CreationBateauTest()
        {
            Bateau bateau = new Bateau();
            bateau.taille = 4; 
            Assert.IsNull(bateau); 
        }
    }
}
