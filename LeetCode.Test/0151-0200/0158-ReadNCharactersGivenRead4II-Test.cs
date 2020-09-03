using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0158_ReadNCharactersGivenRead4II_Test
    {
        [TestMethod]
        public void ReadTest_1()
        {
            var solution = new _0158_ReadNCharactersGivenRead4II();
            solution.FillData("abc");

            var buf = new char[3];
            var result = solution.Read(buf, 1);
            Assert.AreEqual(1, result);
            AssertHelper.AssertArray(new char[] { 'a', '\0', '\0' }, buf);

            buf = new char[3];
            result = solution.Read(buf, 2);
            Assert.AreEqual(2, result);
            AssertHelper.AssertArray(new char[] { 'b', 'c', '\0' }, buf);

            buf = new char[3];
            result = solution.Read(buf, 1);
            Assert.AreEqual(0, result);
            AssertHelper.AssertArray(new char[] { '\0', '\0', '\0' }, buf);
        }

        [TestMethod]
        public void ReadTest_2()
        {
            var solution = new _0158_ReadNCharactersGivenRead4II();
            solution.FillData("abc");

            var buf = new char[3];
            var result = solution.Read(buf, 4);
            Assert.AreEqual(3, result);
            AssertHelper.AssertArray(new char[] { 'a', 'b', 'c' }, buf);

            buf = new char[3];
            result = solution.Read(buf, 1);
            Assert.AreEqual(0, result);
            AssertHelper.AssertArray(new char[] { '\0', '\0', '\0' }, buf);
        }
    }
}
