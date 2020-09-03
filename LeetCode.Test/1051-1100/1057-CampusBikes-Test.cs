using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _1057_CampusBikes_Test
    {
        [TestMethod]
        public void AssignBikesTest_1()
        {
            var solution = new _1057_CampusBikes();
            var result = solution.AssignBikes(
                new int[][] {
                    new int[] {0, 0},
                    new int[] {2, 1}
                },
                new int[][] {
                    new int[] {1, 2},
                    new int[] {3, 3}
                });
            AssertHelper.AssertArray(new int[] {1, 0}, result);
        }

        [TestMethod]
        public void AssignBikesTest_2()
        {
            var solution = new _1057_CampusBikes();
            var result = solution.AssignBikes(
                new int[][] {
                    new int[] {0, 0},
                    new int[] {1, 1},
                    new int[] {2, 0}
                },
                new int[][] {
                    new int[] {1, 0},
                    new int[] {2, 2},
                    new int[] {2, 1}
                });
            AssertHelper.AssertArray(new int[] {0, 2, 1}, result);
        }
    }
}
