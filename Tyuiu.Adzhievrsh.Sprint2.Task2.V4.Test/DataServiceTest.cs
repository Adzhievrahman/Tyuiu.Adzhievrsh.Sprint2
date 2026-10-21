using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.Adzhievrsh.Sprint2.Task2.V4.Lib;

namespace Tyuiu.Adzhievrsh.Sprint2.Task2.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckDot_ShadedCell_ReturnsTrue()
        {
            DataService ds = new DataService();

            Assert.IsTrue(ds.CheckDotInShadedArea(3, 3));
        }

        [TestMethod]
        public void CheckDot_WhiteCell_ReturnsFalse()
        {
            DataService ds = new DataService();

            Assert.IsFalse(ds.CheckDotInShadedArea(1, 1));
        }

        [TestMethod]
        public void CheckDot_AnotherShadedCell_ReturnsTrue()
        {
            DataService ds = new DataService();

            Assert.IsTrue(ds.CheckDotInShadedArea(9, 10));
        }

        [TestMethod]
        public void CheckDot_OutsideGrid_ReturnsFalse()
        {
            DataService ds = new DataService();

            Assert.IsFalse(ds.CheckDotInShadedArea(16, 5));
        }
    }
}