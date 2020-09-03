using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _048_RotateImage_Test
    {
        [TestMethod]
        public void RotateTest_OddLength()
        {
            var input = new int[5, 5] {
                { 1, 2, 3, 4, 5 },
                { 1, 2, 3, 4, 5 },
                { 1, 2, 3, 4, 5 },
                { 1, 2, 3, 4, 5 },
                { 1, 2, 3, 4, 5 }
            };

            var solution = new _048_RotateImage();
            solution.Rotate(input);

            AssertHelper.AssertArray(
                new int[5, 5] {
                    { 1, 1, 1, 1, 1 },
                    { 2, 2, 2, 2, 2 },
                    { 3, 3, 3, 3, 3 },
                    { 4, 4, 4, 4, 4 },
                    { 5, 5, 5, 5, 5 }
                }, input);
        }

        [TestMethod]
        public void RotateTest_EvenLength()
        {
            var input = new int[6, 6] {
                { 1, 2, 3, 4, 5, 6 },
                { 1, 2, 3, 4, 5, 6 },
                { 1, 2, 3, 4, 5, 6 },
                { 1, 2, 3, 4, 5, 6 },
                { 1, 2, 3, 4, 5, 6 },
                { 1, 2, 3, 4, 5, 6 }
            };

            var solution = new _048_RotateImage();
            solution.Rotate(input);

            AssertHelper.AssertArray(
                new int[6, 6] {
                    { 1, 1, 1, 1, 1, 1 },
                    { 2, 2, 2, 2, 2, 2 },
                    { 3, 3, 3, 3, 3, 3 },
                    { 4, 4, 4, 4, 4, 4 },
                    { 5, 5, 5, 5, 5, 5 },
                    { 6, 6, 6, 6, 6, 6 },
                }, input);
        }

        [TestMethod]
        public void RotateTest_Empty()
        {
            var input = new int[0, 0] { };

            var solution = new _048_RotateImage();
            solution.Rotate(input);

            AssertHelper.AssertArray(new int[0, 0] { }, input);
        }

        [TestMethod]
        public void RotateTest_OneItem()
        {
            var input = new int[1, 1] { { 1 } };

            var solution = new _048_RotateImage();
            solution.Rotate(input);

            AssertHelper.AssertArray(new int[1, 1] { { 1 } }, input);
        }
    }
}
