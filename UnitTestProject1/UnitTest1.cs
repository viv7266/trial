using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace UnitTestProject1
{
    using NUnit.Framework;
    [TestFixture]
    class UnitTest1
    {
        [Test]
        public void TestMethod1()
        {
            Assert.AreEqual(10, 5 + 5);
        }
    }
}
