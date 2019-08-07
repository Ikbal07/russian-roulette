using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Iqbal_Russian_Roullete
{
    [TestFixture]
    class Test
    {
        [TestCase]
        public void pos()
        {
            chamber  positivetest= new chamber ();
            Assert.AreEqual(1, positivetest.spinnerchamber(6));
        }

        [TestCase]
        public void neg()
        {
            chamber  negtivetest = new chamber ();
            Assert.AreNotEqual(2, negtivetest.spinnerchamber(6));
        }
    }
}
