using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0170_TwoSumIIIDataStructureDesign_Test
    {
        [TestMethod]
        public void TwoSumIIIDataStructureDesign_1()
        {
            var solution = new _0170_TwoSumIIIDataStructureDesign();

            solution.Add(1);
            solution.Add(3);
            solution.Add(5);

            Assert.IsTrue(solution.Find(4));
            Assert.IsFalse(solution.Find(7));
        }

        [TestMethod]
        public void TwoSumIIIDataStructureDesign_2()
        {
            var solution = new _0170_TwoSumIIIDataStructureDesign();

            solution.Add(3);
            solution.Add(1);
            solution.Add(2);

            Assert.IsTrue(solution.Find(3));
            Assert.IsFalse(solution.Find(6));
        }
    }
}
