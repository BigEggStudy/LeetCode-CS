using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0458_PoorPigs_Test
    {
        [TestMethod]
        public void PoorPigsTest()
        {
            var solution = new _0458_PoorPigs();
            Assert.AreEqual(2, solution.PoorPigs(3, 15, 15));
        }
    }
}
