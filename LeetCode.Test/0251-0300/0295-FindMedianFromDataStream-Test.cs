using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0295_FindMedianFromDataStream_Test
    {
        [TestMethod]
        public void MedianFinderTest()
        {
            var medianFinder = new _0295_FindMedianFromDataStream();

            medianFinder.AddNum(1);
            medianFinder.AddNum(2);
            Assert.AreEqual(1.5, medianFinder.FindMedian());
            medianFinder.AddNum(3);
            Assert.AreEqual(2, medianFinder.FindMedian());
        }
    }
}
