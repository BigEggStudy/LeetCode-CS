using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0207_CourseSchedule_Test
    {
        [TestMethod]
        public void CanFinishTest_1()
        {
            var solution = new _0207_CourseSchedule();
            var result = solution.CanFinish(2, new int[][] { new int[] { 1, 0 } });
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CanFinishTest_2()
        {
            var solution = new _0207_CourseSchedule();
            var result = solution.CanFinish(2, new int[][] { new int[] { 1, 0 }, new int[] { 0, 1 } });
            Assert.IsFalse(result);
        }
    }
}
