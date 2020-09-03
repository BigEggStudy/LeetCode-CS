using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace LeetCode.Test
{
    [TestClass]
    public class _0399_EvaluateDivision_Test
    {
        [TestMethod]
        public void CalcEquationTest()
        {
            var solution = new _0399_EvaluateDivision();
            var result = solution.CalcEquation(
                new List<IList<string>>
                {
                    new List<string> { "a", "b" },
                    new List<string> { "b", "c" },
                },
                new double[] { 2.0, 3.0 },
                new List<IList<string>>
                {
                    new List<string> { "a", "c" },
                    new List<string> { "b", "a" },
                    new List<string> { "a", "e" },
                    new List<string> { "a", "a" },
                    new List<string> { "x", "x" },
                }
            );
        }
    }
}
