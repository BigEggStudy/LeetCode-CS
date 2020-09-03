using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0381_InsertDeleteGetrandomDuplicatesAllowed_Test
    {
        [TestMethod]
        public void RandomizedCollectionTest_1()
        {
            var solution = new _0381_InsertDeleteGetrandomDuplicatesAllowed();

            // Inserts 1 to the collection. Returns true as the collection did not contain 1.
            var result = solution.Insert(1);
            Assert.IsTrue(result);

            // Inserts another 1 to the collection. Returns false as the collection contained 1. Collection now contains [1,1].
            result = solution.Insert(1);
            Assert.IsFalse(result);

            // Inserts 2 to the collection, returns true. Collection now contains [1,1,2].
            result = solution.Insert(2);
            Assert.IsTrue(result);

            // getRandom should return 1 with the probability 2/3, and returns 2 with the probability 1/3.
            var number = solution.GetRandom();
            Assert.IsTrue(number == 1 || number == 2);
            number = solution.GetRandom();
            Assert.IsTrue(number == 1 || number == 2);
            number = solution.GetRandom();
            Assert.IsTrue(number == 1 || number == 2);

            // Removes 1 from the collection, returns true. Collection now contains [1,2].
            result = solution.Remove(1);
            Assert.IsTrue(result);

            // getRandom should return 1 and 2 both equally likely.
            number = solution.GetRandom();
            Assert.IsTrue(number == 1 || number == 2);
            number = solution.GetRandom();
            Assert.IsTrue(number == 1 || number == 2);
            number = solution.GetRandom();
            Assert.IsTrue(number == 1 || number == 2);
        }

        [TestMethod]
        public void RandomizedCollectionTest_2()
        {
            var solution = new _0381_InsertDeleteGetrandomDuplicatesAllowed();

            var result = solution.Insert(4);
            Assert.IsTrue(result);
            result = solution.Insert(3);
            Assert.IsTrue(result);
            result = solution.Insert(4);
            Assert.IsFalse(result);
            result = solution.Insert(2);
            Assert.IsTrue(result);
            result = solution.Insert(4);
            Assert.IsFalse(result);

            result = solution.Remove(4);
            Assert.IsTrue(result);
            result = solution.Remove(3);
            Assert.IsTrue(result);
            result = solution.Remove(4);
            Assert.IsTrue(result);
            result = solution.Remove(4);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void RandomizedCollectionTest_3()
        {
            var solution = new _0381_InsertDeleteGetrandomDuplicatesAllowed();

            var result = solution.Insert(0);
            Assert.IsTrue(result);
            result = solution.Remove(0);
            Assert.IsTrue(result);
            result = solution.Insert(-1);
            Assert.IsTrue(result);
            result = solution.Remove(0);
            Assert.IsFalse(result);
        }
    }
}
