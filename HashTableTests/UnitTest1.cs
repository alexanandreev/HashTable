using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HashTableTests
{

    [TestClass]
    public class HashTableTests
    {
        [TestMethod]
        public void ThreeElementsTest()
        {
            var ht = new HashTable.HashTable(3);

            ht.PutPair("1", "Один");
            ht.PutPair("2", "Два");
            ht.PutPair("3", "Три");

            Assert.AreEqual(ht.GetValueByKey("1"), "Один");
            Assert.AreEqual(ht.GetValueByKey("2"), "Два");
            Assert.AreEqual(ht.GetValueByKey("3"), "Три");
        }

        [TestMethod]
        public void TwoEquialsElementsTest()
        {
            var ht = new HashTable.HashTable(3);

            ht.PutPair("1", "Один");
            ht.PutPair("1", "Два");

            Assert.AreEqual(ht.GetValueByKey("1"), "Два");
        }

        [TestMethod]
        public void BigElementsTest()
        {
            var ht = new HashTable.HashTable(10000);

            for (int i = 0; i < 10000; i++)
            {
                ht.PutPair(i, i + "Один");
            }

            Assert.AreEqual(ht.GetValueByKey(55), "55Один");
        }

        [TestMethod]
        public void BigElementsSearchTests()
        {
            var ht = new HashTable.HashTable(10000);

            for (int i = 0; i < 10000; i++)
            {
                ht.PutPair(i, i + "Один");
            }

            for (int i = 10000; i < 11000; i++)
            {
                Assert.AreEqual(ht.GetValueByKey(i), null);
            }
        }
    }
}
