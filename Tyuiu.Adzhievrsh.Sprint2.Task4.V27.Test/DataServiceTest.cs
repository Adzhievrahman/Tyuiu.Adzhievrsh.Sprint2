using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.Adzhievrsh.Sprint2.Task4.V27.Lib;
using System;

namespace Tyuiu.Adzhievrsh.Sprint2.Task4.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Calculate_FirstCondition_Returns338()
        {
            DataService ds = new DataService();

            double result = ds.Calculate(2, -15);

            Assert.AreEqual(338.0, result, 0.001);
        }

        [TestMethod]
        public void Calculate_SecondCondition_Returns8()
        {
            DataService ds = new DataService();

            double result = ds.Calculate(2, 3);

            Assert.AreEqual(8.0, result, 0.001);
        }

        [TestMethod]
        public void Calculate_XZero_ThrowsException()
        {
            DataService ds = new DataService();
            bool exceptionThrown = false;

            try
            {
                ds.Calculate(0, 0);
            }
            catch (ArgumentException)
            {
                exceptionThrown = true;
            }

            Assert.IsTrue(exceptionThrown);
        }
    }
}