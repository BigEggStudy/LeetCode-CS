using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0420_StrongPasswordChecker_Test
    {
        [TestMethod]
        public void StrongPasswordChecker_1()
        {
            var solution = new _0420_StrongPasswordChecker();
            var result = solution.StrongPasswordChecker("aaa123");
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void StrongPasswordChecker_2()
        {
            var solution = new _0420_StrongPasswordChecker();
            var result = solution.StrongPasswordChecker("aaaaaaaAAAAAA6666bbbbaaaaaaABBC");
            Assert.AreEqual(13, result);
        }

        [TestMethod]
        public void StrongPasswordChecker_3()
        {
            var solution = new _0420_StrongPasswordChecker();
            var result = solution.StrongPasswordChecker("");
            Assert.AreEqual(6, result);
        }

        [TestMethod]
        public void StrongPasswordChecker_4()
        {
            var solution = new _0420_StrongPasswordChecker();
            var result = solution.StrongPasswordChecker("aaa111");
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void StrongPasswordChecker_5()
        {
            var solution = new _0420_StrongPasswordChecker();
            var result = solution.StrongPasswordChecker("abababababababababaaa");
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void StrongPasswordChecker_6()
        {
            var solution = new _0420_StrongPasswordChecker();
            var result = solution.StrongPasswordChecker("aaaaaa1234567890123Ubefg");
            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void StrongPasswordChecker_7()
        {
            var solution = new _0420_StrongPasswordChecker();
            var result = solution.StrongPasswordChecker("aaaaaa1U");
            Assert.AreEqual(2, result);
        }
    }
}
