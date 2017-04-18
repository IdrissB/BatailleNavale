using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace BatailleNavale.Tests
{
    [TestFixture]
    class CaseTest
    {
         
        [Test]
        public void basicTest()
        {
            Case c = new Case();

            Assert.Equals(1,1);

        }
    }
}
