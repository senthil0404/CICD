using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace CICDSample.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            List<string> ob = new List<string>();
            ob.Add("Senthil");
            Assert.IsTrue(ob.Count == 1);
        }
        [TestMethod]
        public void TestMethod2()
        {
            List<string> ob = new List<string>();
            Assert.IsTrue(ob.Count != 1);
        }
    }
}
