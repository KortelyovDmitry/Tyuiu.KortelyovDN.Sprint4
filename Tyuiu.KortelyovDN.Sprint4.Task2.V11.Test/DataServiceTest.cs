using Tyuiu.KortelyovDN.Sprint4.Task2.V11.Lib;

namespace Tyuiu.KortelyovDN.Sprint4.Task2.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[] numsArray = {3, 4, 5, 6, 7, 8, 3, 4, 5, 6, 7, 8, 3, 4, 5};

            int res = ds.Calculate(numsArray);

            int wait = 40;

            Assert.AreEqual(wait, res);
        }
    }
}