using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0657_RobotReturnToOrigin_Test
    {
        [TestMethod]
        public void JudgeCircle_1()
        {
            var solution = new _0657_RobotReturnToOrigin();
            var result = solution.JudgeCircle("UD");
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void JudgeCircle_2()
        {
            var solution = new _0657_RobotReturnToOrigin();
            var result = solution.JudgeCircle("LL");
            Assert.IsFalse(result);
        }
    }
}
