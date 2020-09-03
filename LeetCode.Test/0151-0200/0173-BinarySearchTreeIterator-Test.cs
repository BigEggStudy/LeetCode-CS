using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0173_BinarySearchTreeIterator_Test
    {
        [TestMethod]
        public void BSTIteratorTest()
        {
            var root = TestHelper.GenerateTree(new int?[] { 7, 3, 15, null, null, 9, 20 });

            var iterator = new _0173_BinarySearchTreeIterator(root);
            Assert.AreEqual(3, iterator.Next());    // return 3
            Assert.AreEqual(7, iterator.Next());    // return 7
            Assert.IsTrue(iterator.HasNext());      // return true

            Assert.AreEqual(9, iterator.Next());    // return 9
            Assert.IsTrue(iterator.HasNext());      // return true

            Assert.AreEqual(15, iterator.Next());   // return 15
            Assert.IsTrue(iterator.HasNext());      // return true

            Assert.AreEqual(20, iterator.Next());   // return 20
            Assert.IsFalse(iterator.HasNext());     // return false
        }
    }
}
