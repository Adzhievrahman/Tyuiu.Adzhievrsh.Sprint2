using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.Adzhievrsh.Sprint2.Task5.V15.Lib;
using System;

namespace Tyuiu.Adzhievrsh.Sprint2.Task5.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void FindDayName_Day1_ReturnsMonday()
        {
            DataService ds = new DataService();

            Assert.AreEqual("Понедельник", ds.FindDayName(1));
        }

        [TestMethod]
        public void FindDayName_Day7_ReturnsSunday()
        {
            DataService ds = new DataService();

            Assert.AreEqual("Воскресенье", ds.FindDayName(7));
        }

        [TestMethod]
        public void FindDayName_Day8_ReturnsMonday()
        {
            DataService ds = new DataService();

            Assert.AreEqual("Понедельник", ds.FindDayName(8));
        }

        [TestMethod]
        public void FindDayName_Day365_ReturnsMonday()
        {
            DataService ds = new DataService();

            Assert.AreEqual("Понедельник", ds.FindDayName(365));
        }

        [TestMethod]
        public void FindDayName_InvalidDay_ThrowsException()
        {
            DataService ds = new DataService();
            bool exceptionThrown = false;

            try
            {
                ds.FindDayName(0);
            }
            catch (ArgumentException)
            {
                exceptionThrown = true;
            }

            Assert.IsTrue(exceptionThrown);
        }
    }
}