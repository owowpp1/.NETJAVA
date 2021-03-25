using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using LAB1;

namespace Testy
{
    [TestClass]
    public class Test_ulozenia
    {
        [TestMethod]
        public void Czy_6_Dla_100kg()
        {
            Assert.AreEqual(6, new Program().ustaf(2, 9, 100));
        }
        [TestMethod]
        public void Czy_nie_9_dla_100kg()
        {
            Assert.AreNotEqual(9, new Program().ustaf(2, 9, 100));
        }
        [TestMethod]
        public void Czy_11_dla_150kg()
        {
            Assert.AreEqual(11, new Program().ustaf(2, 9, 150));
        }
        [TestMethod]
        public void Czy_nie_9_dla_150kg()
        {
            Assert.AreNotEqual(9, new Program().ustaf(2, 9, 150));
        }
    }
}
