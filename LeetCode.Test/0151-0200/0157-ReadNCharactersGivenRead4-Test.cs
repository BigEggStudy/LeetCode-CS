using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0157_ReadNCharactersGivenRead4_Test
    {
        [TestMethod]
        public void Read_1()
        {
            var buf = new char[4];

            var solution = new _0157_ReadNCharactersGivenRead4("abc");
            var result = solution.Read(buf, 4);
            Assert.AreEqual(3, result);
            AssertHelper.AssertArray("abc".ToCharArray(), buf, true);
        }

        [TestMethod]
        public void Read_2()
        {
            var buf = new char[5];

            var solution = new _0157_ReadNCharactersGivenRead4("abcde");
            var result = solution.Read(buf, 5);
            Assert.AreEqual(5, result);
            AssertHelper.AssertArray("abcde".ToCharArray(), buf, true);
        }

        [TestMethod]
        public void Read_3()
        {
            var buf = new char[12];

            var solution = new _0157_ReadNCharactersGivenRead4("abcdABCD1234");
            var result = solution.Read(buf, 12);
            Assert.AreEqual(12, result);
            AssertHelper.AssertArray("abcdABCD1234".ToCharArray(), buf, true);
        }

        [TestMethod]
        public void Read_4()
        {
            var buf = new char[5];

            var solution = new _0157_ReadNCharactersGivenRead4("leetcode");
            var result = solution.Read(buf, 5);
            Assert.AreEqual(5, result);
            AssertHelper.AssertArray("leetc".ToCharArray(), buf, true);
        }
    }
}
