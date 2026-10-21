using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.Adzhievrsh.Sprint2.Task3.V17.Lib;
using System;

namespace Tyuiu.Adzhievrsh.Sprint2.Task3.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Calculate_X2_Returns6565()
        {
            DataService ds = new DataService();

            double result = ds.Calculate(2);

            Assert.AreEqual(6565.0, result, 0.001);
        }

        [TestMethod]
        public void Calculate_X0_ReturnsNegative0286()
        {
            DataService ds = new DataService();

            double result = ds.Calculate(0);

            Assert.AreEqual(-0.286, result, 0.001);
        }

        [TestMethod]
        public void Calculate_X1_Returns16()
        {
            DataService ds = new DataService();

            double result = ds.Calculate(1);

            Assert.AreEqual(16.0, result, 0.001);
        }

        [TestMethod]
        public void Calculate_XMinus22_ReturnsNegative241955()
        {
            DataService ds = new DataService();

            double result = ds.Calculate(-22);

            Assert.AreEqual(-241.955, result, 0.001);
        }

        [TestMethod]
        public void Calculate_XMinus21_ThrowsException()
        {
            DataService ds = new DataService();
            bool exceptionThrown = false;

            try
            {
                ds.Calculate(-21);
            }
            catch (ArgumentException)
            {
                exceptionThrown = true;
            }

            Assert.IsTrue(exceptionThrown);
        }
    }
}