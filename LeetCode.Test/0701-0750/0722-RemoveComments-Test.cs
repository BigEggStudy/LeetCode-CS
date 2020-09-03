using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0722_RemoveComments_Test
    {
        [TestMethod]
        public void RemoveComments_1()
        {
            var solution = new _0722_RemoveComments();
            var result = solution.RemoveComments(new string[] { "/*Test program */", "int main()", "{ ", "  // variable declaration ", "int a, b, c;", "/* This is a test", "   multiline  ", "   comment for ", "   testing */", "a = b + c;", "}" });
            AssertHelper.AssertList(new string[] { "int main()", "{ ", "  ", "int a, b, c;", "a = b + c;", "}" }, result);
        }

        [TestMethod]
        public void RemoveComments_2()
        {
            var solution = new _0722_RemoveComments();
            var result = solution.RemoveComments(new string[] { "a/*comment", "line", "more_comment*/b" });
            AssertHelper.AssertList(new string[] { "ab" }, result);
        }
    }
}
