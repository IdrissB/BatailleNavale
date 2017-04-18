using System;
using NUnit.Framework;
using BatailleNavale;

namespace BatailleNavale.Tests
{
    [TestFixture]
    public class BateauTest
    {
        [Test]
        public void CreationBateauTest()
        {
            Bateau bateau = new Bateau();
            bateau.taille = 4; 
            Assert.IsNull(bateau); 
        }
    }
}
