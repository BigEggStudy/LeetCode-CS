using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace LeetCode.Test
{
    [TestClass]
    public class _0609_FindDuplicateFileInSystem_Test
    {
        [TestMethod]
        public void FindDuplicate_1()
        {
            var solution = new _0609_FindDuplicateFileInSystem();
            var result = solution.FindDuplicate(new string[] { "root/a 1.txt(abcd) 2.txt(efgh)", "root/c 3.txt(abcd)", "root/c/d 4.txt(efgh)", "root 4.txt(efgh)" });
            AssertHelper.AssertList(new List<IList<string>>() {
                new string[] { "root/a/1.txt", "root/c/3.txt" },
                new string[] { "root/a/2.txt", "root/c/d/4.txt", "root/4.txt" },
            }, result);
        }
    }
}
