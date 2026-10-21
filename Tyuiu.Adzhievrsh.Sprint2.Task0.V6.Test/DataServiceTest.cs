using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.Adzhievrsh.Sprint2.Task0.V6.Lib;

namespace Tyuiu.Adzhievrsh.Sprint2.Task0.V6.Test
{
    [TestClass]
    public class DataServiceTests
    {
        [TestMethod]
        public void GetCompareOperations_ReturnsCorrectResult()
        {
            DataService ds = new DataService();

            bool[] result = ds.GetCompareOperations(107, 754);

            bool[] expected =
            {
                true, true, true, false, true, false
            };

            CollectionAssert.AreEqual(expected, result);
        }
    }
}