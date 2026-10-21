using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.Adzhievrsh.Sprint2.Task1.V5.Lib;

namespace Tyuiu.Adzhievrsh.Sprint2.Task1.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void GetLogicOperationsValid()
        {
            DataService ds = new DataService();

            int a = 154;
            int b = 163;
            int c = 134;
            int d = 137;

            bool[] expected = { true, false, false, false, true, false };
            bool[] actual = ds.GetLogicOperations(a, b, c, d);

            CollectionAssert.AreEqual(expected, actual);
        }
    }
}