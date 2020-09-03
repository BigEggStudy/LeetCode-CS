using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _1395_CountNumberOfTeams_Test
    {
        [TestMethod]
        public void NumTeams_1()
        {
            var solution = new _1395_CountNumberOfTeams();
            var result = solution.NumTeams(new int[] { 2, 5, 3, 4, 1 });
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void NumTeams_2()
        {
            var solution = new _1395_CountNumberOfTeams();
            var result = solution.NumTeams(new int[] { 2, 1, 3 });
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void NumTeams_3()
        {
            var solution = new _1395_CountNumberOfTeams();
            var result = solution.NumTeams(new int[] { 1, 2, 3, 4 });
            Assert.AreEqual(4, result);
        }
    }
}
