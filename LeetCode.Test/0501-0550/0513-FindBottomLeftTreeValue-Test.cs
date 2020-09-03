using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0513_FindBottomLeftTreeValue_Test
    {
        [TestMethod]
        public void FindBottomLeftValue_1()
        {
            var root = TestHelper.GenerateTree(new int?[] { 2, 1, 3 });

            var solution = new _0513_FindBottomLeftTreeValue();
            var result = solution.FindBottomLeftValue(root);
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void FindBottomLeftValue_2()
        {
            var root = TestHelper.GenerateTree(new int?[] { 1, 2, 3, 4, null, 5, 6, null, null, 7 });

            var solution = new _0513_FindBottomLeftTreeValue();
            var result = solution.FindBottomLeftValue(root);
            Assert.AreEqual(7, result);
        }
    }
}
