using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0937_ReorderDataInLogFiles_Test
    {
        [TestMethod]
        public void ReorderLogFilesTest()
        {
            var solution = new _0937_ReorderDataInLogFiles();
            var result = solution.ReorderLogFiles(new string[] { "dig1 8 1 5 1", "let1 art can", "dig2 3 6", "let2 own kit dig", "let3 art zero" });
            AssertHelper.AssertArray(new string[] { "let1 art can", "let3 art zero", "let2 own kit dig", "dig1 8 1 5 1", "dig2 3 6" }, result);
        }

        [TestMethod]
        public void ReorderLogFilesTest_2()
        {
            var solution = new _0937_ReorderDataInLogFiles();
            var result = solution.ReorderLogFiles(new string[] { "6p tzwmh ige mc", "ns 566543603829", "ubd cujg j d yf", "ha6 1 938 376 5", "3yx 97 666 56 5", "d 84 34353 2249", "0 tllgmf qp znc", "s 1088746413789", "ys0 splqqxoflgx", "uhb rfrwt qzx r", "u lrvmdt ykmox", "ah4 4209164350", "rap 7729 8 125", "4 nivgc qo z i", "apx 814023338 8" });
            AssertHelper.AssertArray(new string[] { "ubd cujg j d yf", "u lrvmdt ykmox", "4 nivgc qo z i", "uhb rfrwt qzx r", "ys0 splqqxoflgx", "0 tllgmf qp znc", "6p tzwmh ige mc", "ns 566543603829", "ha6 1 938 376 5", "3yx 97 666 56 5", "d 84 34353 2249", "s 1088746413789", "ah4 4209164350", "rap 7729 8 125", "apx 814023338 8" }, result);
        }

        [TestMethod]
        public void ReorderLogFilesTest_3()
        {
            var solution = new _0937_ReorderDataInLogFiles();
            var result = solution.ReorderLogFiles(new string[] { "l5sh 6 3869 08 1295", "16o 94884717383724 9", "43 490972281212 3 51", "9 ehyjki ngcoobi mi", "2epy 85881033085988", "7z fqkbxxqfks f y dg", "9h4p 5 791738 954209", "p i hz uubk id s m l", "wd lfqgmu pvklkdp u", "m4jl 225084707500464", "6np2 bqrrqt q vtap h", "e mpgfn bfkylg zewmg", "ttzoz 035658365825 9", "k5pkn 88312912782538", "ry9 8231674347096 00", "w 831 74626 07 353 9", "bxao armngjllmvqwn q", "0uoj 9 8896814034171", "0 81650258784962331", "t3df gjjn nxbrryos b" });
            AssertHelper.AssertArray(new string[] { "bxao armngjllmvqwn q", "6np2 bqrrqt q vtap h", "9 ehyjki ngcoobi mi", "7z fqkbxxqfks f y dg", "t3df gjjn nxbrryos b", "p i hz uubk id s m l", "wd lfqgmu pvklkdp u", "e mpgfn bfkylg zewmg", "l5sh 6 3869 08 1295", "16o 94884717383724 9", "43 490972281212 3 51", "2epy 85881033085988", "9h4p 5 791738 954209", "m4jl 225084707500464", "ttzoz 035658365825 9", "k5pkn 88312912782538", "ry9 8231674347096 00", "w 831 74626 07 353 9", "0uoj 9 8896814034171", "0 81650258784962331" }, result);
        }
    }
}
