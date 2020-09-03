using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0380_InsertDeleteGetRandom_Test
    {
        [TestMethod]
        public void RandomizedSetTest()
        {
            // Init an empty set.
            var randomSet = new _0380_InsertDeleteGetRandom();

            // Inserts 1 to the set. Returns true as 1 was inserted successfully.
            var result = randomSet.Insert(1);
            Assert.IsTrue(result);

            // Returns false as 2 does not exist in the set.
            result = randomSet.Remove(2);
            Assert.IsFalse(result);

            // Inserts 2 to the set, returns true. Set now contains [1,2].
            result = randomSet.Insert(2);
            Assert.IsTrue(result);

            // getRandom should return either 1 or 2 randomly.
            var number = randomSet.GetRandom();
            Assert.IsTrue(number == 1 || number == 2);
            number = randomSet.GetRandom();
            Assert.IsTrue(number == 1 || number == 2);
            number = randomSet.GetRandom();
            Assert.IsTrue(number == 1 || number == 2);

            // Removes 1 from the set, returns true. Set now contains [2].
            result = randomSet.Remove(1);
            Assert.IsTrue(result);

            // 2 was already in the set, so return false.
            result = randomSet.Insert(2);
            Assert.IsFalse(result);

            // Since 2 is the only number in the set, getRandom always return 2.
            number = randomSet.GetRandom();
            Assert.AreEqual(2, number);
            number = randomSet.GetRandom();
            Assert.AreEqual(2, number);
            number = randomSet.GetRandom();
            Assert.AreEqual(2, number);
        }
    }
}
