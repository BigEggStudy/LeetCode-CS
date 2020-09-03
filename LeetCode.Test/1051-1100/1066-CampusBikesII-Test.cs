using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _1066_CampusBikesII_Test
    {
        [TestMethod]
        public void AssignBikesTest_1()
        {
            var solution = new _1066_CampusBikesII();
            var result = solution.AssignBikes(
                new int[][] {
                    new int[] {0, 0},
                    new int[] {2, 1}
                },
                new int[][] {
                    new int[] {1, 2},
                    new int[] {3, 3}
                });
            Assert.AreEqual(6, result);
        }

        [TestMethod]
        public void AssignBikesTest_2()
        {
            var solution = new _1066_CampusBikesII();
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
            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void AssignBikesTest_3()
        {
            var solution = new _1066_CampusBikesII();
            var result = solution.AssignBikes(
                new int[][] {
                    new int[] {0, 0},
                    new int[] {1, 0},
                    new int[] {2, 0},
                    new int[] {3, 0},
                    new int[] {4, 0},
                    new int[] {5, 0},
                    new int[] {6, 0},
                    new int[] {7, 0},
                    new int[] {8, 0}
                },
                new int[][] {
                    new int[] {0, 999},
                    new int[] {1, 999},
                    new int[] {2, 999},
                    new int[] {3, 999},
                    new int[] {4, 999},
                    new int[] {5, 999},
                    new int[] {6, 999},
                    new int[] {7, 999},
                    new int[] {8, 999},
                    new int[] {9, 999}
                });
            Assert.AreEqual(8991, result);
        }
    }
}
