using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace DotNetProjectWithTest
{
    [TestClass]
    public class UnitTestSample
    {
        [TestMethod]
        public void CheckEqualityTestPass()
        {
            int a = 2, b = 2;
            Assert.AreEqual(a, b);
        }

        [TestMethod]
        public void CheckEqualityTestFail()
        {
            int a = 3, b = 2;
            Assert.AreEqual(a, b);
        }

        [TestMethod]
        public void CheckTrueTestPass()
        {
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void CheckTrueTestFail()
        {
            Assert.IsTrue(false);
        }
    }
}
