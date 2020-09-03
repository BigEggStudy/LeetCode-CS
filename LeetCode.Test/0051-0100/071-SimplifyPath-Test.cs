using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _071_SimplifyPath_Test
    {
        [TestMethod]
        public void SimplifyPathTest()
        {
            var input = "/home/";

            var solution = new _071_SimplifyPath();
            var result = solution.SimplifyPath(input);

            Assert.AreEqual("/home", result);
        }

        [TestMethod]
        public void SimplifyPathTest_OnlyBack()
        {

            var input = "/..";

            var solution = new _071_SimplifyPath();
            var result = solution.SimplifyPath(input);

            Assert.AreEqual("/", result);
        }

        [TestMethod]
        public void SimplifyPathTest_WithBack()
        {

            var input = "/a/../c/";

            var solution = new _071_SimplifyPath();
            var result = solution.SimplifyPath(input);

            Assert.AreEqual("/c", result);
        }

        [TestMethod]
        public void SimplifyPathTest_WithMultipleBack()
        {

            var input = "/a/b/../../c/";

            var solution = new _071_SimplifyPath();
            var result = solution.SimplifyPath(input);

            Assert.AreEqual("/c", result);
        }

        [TestMethod]
        public void SimplifyPathTest_WithCurrentFolder()
        {

            var input = "/a/./b/../../c/";

            var solution = new _071_SimplifyPath();
            var result = solution.SimplifyPath(input);

            Assert.AreEqual("/c", result);
        }

        [TestMethod]
        public void SimplifyPathTest_WithEmptyFolder()
        {

            var input = "/home//foo//";

            var solution = new _071_SimplifyPath();
            var result = solution.SimplifyPath(input);

            Assert.AreEqual("/home/foo", result);
        }
    }
}
