using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _065_ValidNumber_Test
    {
        [TestMethod]
        public void IsNumberTest_IsNumber()
        {
            var soluion = new _065_ValidNumber();
            var result = soluion.IsNumber("123");

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsNumberTest_IsNumber_Positive()
        {
            var soluion = new _065_ValidNumber();
            var result = soluion.IsNumber("+123");

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsNumberTest_IsNumber_Nagative()
        {
            var soluion = new _065_ValidNumber();
            var result = soluion.IsNumber("-123");

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsNumberTest_IsNumber_SpaceStart()
        {
            var soluion = new _065_ValidNumber();
            var result = soluion.IsNumber("   123");

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsNumberTest_IsNumber_SpaceEnd()
        {
            var soluion = new _065_ValidNumber();
            var result = soluion.IsNumber("123   ");

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsNumberTest_IsNumber_SpaceBothStartAndEnd()
        {
            var soluion = new _065_ValidNumber();
            var result = soluion.IsNumber("   123   ");

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsNumberTest_IsNumber_WithPoint()
        {
            var soluion = new _065_ValidNumber();
            var result = soluion.IsNumber(".123");

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsNumberTest_IsNumber_WithPoint_2()
        {
            var soluion = new _065_ValidNumber();
            var result = soluion.IsNumber("123.123");

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsNumberTest_IsNumber_PointAtEnd()
        {
            var soluion = new _065_ValidNumber();
            var result = soluion.IsNumber("123.");

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsNumberTest_IsNumber_SpaceAfterPoint()
        {
            var soluion = new _065_ValidNumber();
            var result = soluion.IsNumber("123.   ");

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsNumberTest_IsNumber_WithE()
        {
            var soluion = new _065_ValidNumber();
            var result = soluion.IsNumber("2e10");

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsNumberTest_IsNumber_WithE_UpperCase()
        {
            var soluion = new _065_ValidNumber();
            var result = soluion.IsNumber("2E10");

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsNumberTest_IsNumber_WithE_PositiveE()
        {
            var soluion = new _065_ValidNumber();
            var result = soluion.IsNumber("2e+10");

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsNumberTest_IsNumber_WithE_NagativeE()
        {
            var soluion = new _065_ValidNumber();
            var result = soluion.IsNumber("2e-10");

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsNumberTest_IsNumber_WithPoint_WithE()
        {
            var soluion = new _065_ValidNumber();
            var result = soluion.IsNumber("2.12e10");

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsNumberTest_IsNumber_WithPoint_WithE_2()
        {
            var soluion = new _065_ValidNumber();
            var result = soluion.IsNumber("123.e1");

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsNumberTest_IsNotNumber()
        {
            var soluion = new _065_ValidNumber();
            var result = soluion.IsNumber("abc");

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsNumberTest_IsNotNumber_Mixed()
        {
            var soluion = new _065_ValidNumber();
            var result = soluion.IsNumber("1 aa");

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsNumberTest_IsNotNumber_WithTwoPoint()
        {
            var soluion = new _065_ValidNumber();
            var result = soluion.IsNumber(".12.3");

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsNumberTest_IsNotNumber_OnlyPoint()
        {
            var soluion = new _065_ValidNumber();
            var result = soluion.IsNumber(".");

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsNumberTest_IsNotNumber_OnlyPoint_WithEmptyStart()
        {
            var soluion = new _065_ValidNumber();
            var result = soluion.IsNumber("  .");

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsNumberTest_IsNotNumber_OnlyPoint_WithEmptyEnd()
        {
            var soluion = new _065_ValidNumber();
            var result = soluion.IsNumber(".  ");

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsNumberTest_IsNotNumber_OnlyPoint_WithEmptyBothStartAndEnd()
        {
            var soluion = new _065_ValidNumber();
            var result = soluion.IsNumber("  .  ");

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsNumberTest_IsNotNumber_PointBeforeNonDigit()
        {
            var soluion = new _065_ValidNumber();
            var result = soluion.IsNumber(".a");

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsNumberTest_IsNotNumber_WithTwoE()
        {
            var soluion = new _065_ValidNumber();
            var result = soluion.IsNumber("2e12e10");

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsNumberTest_IsNotNumber_WithE_Poistive()
        {
            var soluion = new _065_ValidNumber();
            var result = soluion.IsNumber("210e+");

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsNumberTest_IsNotNumber_WithE_Nagative()
        {
            var soluion = new _065_ValidNumber();
            var result = soluion.IsNumber("210e-");

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsNumberTest_IsNotNumber_WithE_EAtEnd()
        {
            var soluion = new _065_ValidNumber();
            var result = soluion.IsNumber("210e");

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsNumberTest_IsNotNumber_WithE_EAtStart()
        {
            var soluion = new _065_ValidNumber();
            var result = soluion.IsNumber("e210");

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsNumberTest_IsNotNumber_WithE_PointAfterE()
        {
            var soluion = new _065_ValidNumber();
            var result = soluion.IsNumber("e2.1");

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsNumberTest_IsNotNumber_WithPoint_WithE()
        {
            var soluion = new _065_ValidNumber();
            var result = soluion.IsNumber(".e1");

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsNumberTest_IsNotNumber_WithPoint_WithE_2()
        {
            var soluion = new _065_ValidNumber();
            var result = soluion.IsNumber("1e.");

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsNumberTest_IsNotNumber_OnlySpace()
        {
            var soluion = new _065_ValidNumber();
            var result = soluion.IsNumber("  ");

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsNumberTest_IsNotNumber_CharAfterSpace()
        {
            var soluion = new _065_ValidNumber();
            var result = soluion.IsNumber(" 12 1");

            Assert.IsFalse(result);
        }
    }
}
