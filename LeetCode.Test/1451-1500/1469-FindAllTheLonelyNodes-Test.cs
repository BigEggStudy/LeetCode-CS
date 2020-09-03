using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _1469_FindAllTheLonelyNodes_Test
    {
        [TestMethod]
        public void GetLonelyNodes_1()
        {
            var root = TestHelper.GenerateTree(new int?[] { 1, 2, 3, null, 4 });

            var solution = new _1469_FindAllTheLonelyNodes();
            var result = solution.GetLonelyNodes(root);
            AssertHelper.AssertList(new int[] { 4 }, result);
        }

        [TestMethod]
        public void GetLonelyNodes_2()
        {
            var root = TestHelper.GenerateTree(new int?[] { 7, 1, 4, 6, null, 5, 3, null, null, null, null, null, 2 });

            var solution = new _1469_FindAllTheLonelyNodes();
            var result = solution.GetLonelyNodes(root);
            AssertHelper.AssertList(new int[] { 6, 2 }, result);
        }

        [TestMethod]
        public void GetLonelyNodes_3()
        {
            var root = TestHelper.GenerateTree(new int?[] { 11, 99, 88, 77, null, null, 66, 55, null, null, 44, 33, null, null, 22 });

            var solution = new _1469_FindAllTheLonelyNodes();
            var result = solution.GetLonelyNodes(root);
            AssertHelper.AssertList(new int[] { 77, 55, 33, 66, 44, 22 }, result);
        }

        [TestMethod]
        public void GetLonelyNodes_4()
        {
            var root = TestHelper.GenerateTree(new int?[] { 197 });

            var solution = new _1469_FindAllTheLonelyNodes();
            var result = solution.GetLonelyNodes(root);
            Assert.AreEqual(0, result.Count);
        }

        [TestMethod]
        public void GetLonelyNodes_5()
        {
            var root = TestHelper.GenerateTree(new int?[] { 31, null, 78, null, 28 });

            var solution = new _1469_FindAllTheLonelyNodes();
            var result = solution.GetLonelyNodes(root);
            AssertHelper.AssertList(new int[] { 78, 28 }, result);
        }
    }
}
