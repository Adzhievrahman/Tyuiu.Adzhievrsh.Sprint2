using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.Adzhievrsh.Sprint2.Task7.V13.Lib;

namespace Tyuiu.Adzhievrsh.Sprint2.Task7.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckDot_InsideCircle_ReturnsTrue()
        {
            DataService ds = new DataService();

            Assert.IsTrue(ds.CheckDotInShadedArea(0, 0));
        }

        [TestMethod]
        public void CheckDot_InsideTriangle_ReturnsTrue()
        {
            DataService ds = new DataService();

            Assert.IsTrue(ds.CheckDotInShadedArea(1.5, 0.75));
        }

        [TestMethod]
        public void CheckDot_LeftOfYAxis_ReturnsFalse()
        {
            DataService ds = new DataService();

            Assert.IsFalse(ds.CheckDotInShadedArea(-0.5, 0));
        }

        [TestMethod]
        public void CheckDot_OutsideShadedArea_ReturnsFalse()
        {
            DataService ds = new DataService();

            Assert.IsFalse(ds.CheckDotInShadedArea(2, 0));
        }
    }
}