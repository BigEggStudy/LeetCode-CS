using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _057_InsertInterval_Test
    {
        [TestMethod]
        public void InsertTest_NoOverlap_Before()
        {
            var input = new[]
            {
                new Interval(4, 6),
                new Interval(8, 10)
            };

            var solution = new _057_InsertInterval();
            var result = solution.Insert(input, new Interval(1, 3));

            Assert.AreEqual(3, result.Count);
            Assert.AreEqual(1, result[0].start);
            Assert.AreEqual(3, result[0].end);
            Assert.AreEqual(4, result[1].start);
            Assert.AreEqual(6, result[1].end);
            Assert.AreEqual(8, result[2].start);
            Assert.AreEqual(10, result[2].end);
        }

        [TestMethod]
        public void InsertTest_NoOverlap_Middle()
        {
            var input = new[]
            {
                new Interval(1, 3),
                new Interval(8, 10)
            };

            var solution = new _057_InsertInterval();
            var result = solution.Insert(input, new Interval(4, 6));

            Assert.AreEqual(3, result.Count);
            Assert.AreEqual(1, result[0].start);
            Assert.AreEqual(3, result[0].end);
            Assert.AreEqual(4, result[1].start);
            Assert.AreEqual(6, result[1].end);
            Assert.AreEqual(8, result[2].start);
            Assert.AreEqual(10, result[2].end);
        }

        [TestMethod]
        public void InsertTest_NoOverlap_Last()
        {
            var input = new[]
            {
                new Interval(1, 3),
                new Interval(4, 6)
            };

            var solution = new _057_InsertInterval();
            var result = solution.Insert(input, new Interval(8, 10));

            Assert.AreEqual(3, result.Count);
            Assert.AreEqual(1, result[0].start);
            Assert.AreEqual(3, result[0].end);
            Assert.AreEqual(4, result[1].start);
            Assert.AreEqual(6, result[1].end);
            Assert.AreEqual(8, result[2].start);
            Assert.AreEqual(10, result[2].end);
        }

        [TestMethod]
        public void InsertTest_Overlap()
        {
            var input = new[]
            {
                new Interval(1, 3),
                new Interval(6, 9)
            };

            var solution = new _057_InsertInterval();
            var result = solution.Insert(input, new Interval(2, 5));

            Assert.AreEqual(2, result.Count);
            Assert.AreEqual(1, result[0].start);
            Assert.AreEqual(5, result[0].end);
            Assert.AreEqual(6, result[1].start);
            Assert.AreEqual(9, result[1].end);
        }

        [TestMethod]
        public void InsertTest_MultipleOverlap()
        {
            var input = new[]
            {
                new Interval(1, 2),
                new Interval(3, 5),
                new Interval(6, 7),
                new Interval(8, 10),
                new Interval(12, 16)
            };

            var solution = new _057_InsertInterval();
            var result = solution.Insert(input, new Interval(4, 9));

            Assert.AreEqual(3, result.Count);
            Assert.AreEqual(1, result[0].start);
            Assert.AreEqual(2, result[0].end);
            Assert.AreEqual(3, result[1].start);
            Assert.AreEqual(10, result[1].end);
            Assert.AreEqual(12, result[2].start);
            Assert.AreEqual(16, result[2].end);
        }

        [TestMethod]
        public void InsertTest_EmptyIntervals()
        {
            var solution = new _057_InsertInterval();
            var result = solution.Insert(new Interval[] { }, new Interval(4, 6));

            Assert.AreEqual(1, result.Count);
            Assert.AreEqual(4, result[0].start);
            Assert.AreEqual(6, result[0].end);
        }
    }
}
