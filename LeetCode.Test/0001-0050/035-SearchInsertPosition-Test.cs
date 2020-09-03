using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _035_SearchInsertPosition_Test
    {
        [TestMethod]
        public void SearchInsertTest_Exist()
        {
            var input = new int[] { 1, 3, 5, 6 };
            var solution = new _035_SearchInsertPosition();

            var result = solution.SearchInsert(input, 1);
            Assert.AreEqual(0, result);

            result = solution.SearchInsert(input, 3);
            Assert.AreEqual(1, result);

            result = solution.SearchInsert(input, 5);
            Assert.AreEqual(2, result);

            result = solution.SearchInsert(input, 6);
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void SearchInsertTest_NotExist_Inside()
        {
            var input = new int[] { 1, 3, 5, 6 };
            var solution = new _035_SearchInsertPosition();

            var result = solution.SearchInsert(input, 2);
            Assert.AreEqual(1, result);

            result = solution.SearchInsert(input, 4);
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void SearchInsertTest_NotExist_LessThanMininum()
        {
            var input = new int[] { 1, 3, 5, 6 };
            var solution = new _035_SearchInsertPosition();

            var result = solution.SearchInsert(input, 0);
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void SearchInsertTest_NotExist_LargerThanMaxium()
        {
            var input = new int[] { 1, 3, 5, 6 };
            var solution = new _035_SearchInsertPosition();

            var result = solution.SearchInsert(input, 7);
            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void SearchInsertTest_OneItem_Exist()
        {
            var input = new int[] { 3 };
            var solution = new _035_SearchInsertPosition();

            var result = solution.SearchInsert(input, 3);
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void SearchInsertTest_OneItem_NotExist()
        {
            var input = new int[] { 3 };
            var solution = new _035_SearchInsertPosition();

            var result = solution.SearchInsert(input, 2);
            Assert.AreEqual(0, result);

            result = solution.SearchInsert(input, 4);
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void SearchInsertTest_EmptyInput()
        {
            var solution = new _035_SearchInsertPosition();

            var result = solution.SearchInsert(new int[] { }, 2);
            Assert.AreEqual(0, result);
        }
    }
}
