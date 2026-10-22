using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.Adzhievrsh.Sprint2.Task6.V5.Lib;
using System;

namespace Tyuiu.Adzhievrsh.Sprint2.Task6.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void FindCardValue_6_ReturnsSix()
        {
            DataService ds = new DataService();

            Assert.AreEqual("шестёрка", ds.FindCardValue(6));
        }

        [TestMethod]
        public void FindCardValue_11_ReturnsJack()
        {
            DataService ds = new DataService();

            Assert.AreEqual("валет", ds.FindCardValue(11));
        }

        [TestMethod]
        public void FindCardValue_12_ReturnsQueen()
        {
            DataService ds = new DataService();

            Assert.AreEqual("дама", ds.FindCardValue(12));
        }

        [TestMethod]
        public void FindCardValue_14_ReturnsAce()
        {
            DataService ds = new DataService();

            Assert.AreEqual("туз", ds.FindCardValue(14));
        }

        [TestMethod]
        public void FindCardValue_InvalidNumber_ThrowsException()
        {
            DataService ds = new DataService();
            bool exceptionThrown = false;

            try
            {
                ds.FindCardValue(15);
            }
            catch (ArgumentException)
            {
                exceptionThrown = true;
            }

            Assert.IsTrue(exceptionThrown);
        }
    }
}