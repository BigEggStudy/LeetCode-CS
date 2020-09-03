using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0705_DesignHashset_Test
    {
        [TestMethod]
        public void MyHashSet_1()
        {
            var hashSet = new _0705_DesignHashset();

            hashSet.Add(1);
            hashSet.Add(2);
            Assert.IsTrue(hashSet.Contains(1));
            Assert.IsFalse(hashSet.Contains(3));
            hashSet.Add(2);
            Assert.IsTrue(hashSet.Contains(2));
            hashSet.Remove(2);
            Assert.IsFalse(hashSet.Contains(2));
        }
    }
}
