using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0717_1BitAnd2BitCharacters_Test
    {
        [TestMethod]
        public void IsOneBitCharacter_1()
        {
            var solution = new _0717_1BitAnd2BitCharacters();
            var result = solution.IsOneBitCharacter(new int[] { 1, 0, 0 });
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsOneBitCharacter_2()
        {
            var solution = new _0717_1BitAnd2BitCharacters();
            var result = solution.IsOneBitCharacter(new int[] { 1, 1, 1, 0 });
            Assert.IsFalse(result);
        }
    }
}
