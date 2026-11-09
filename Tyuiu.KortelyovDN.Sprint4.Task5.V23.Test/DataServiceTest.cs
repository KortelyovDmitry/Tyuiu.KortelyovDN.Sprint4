using Tyuiu.KortelyovDN.Sprint4.Task5.V23.Lib;

namespace Tyuiu.KortelyovDN.Sprint4.Task5.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[,] matrix = new int[5, 5] { { -4, 4, 6, 6, 5 },
                                            { 6, -1, 6, 3, 5 },
                                            { 5, 3, -3, 7, 6 },
                                            { 6, 4, 7, -2, 6 },
                                            { 7, 4, 3, 4, -4 } };

            int[,] wait = new int[5, 5] { { 0, 4, 6, 6, 5 },
                                          { 6, 0, 6, 3, 5 },
                                          { 5, 3, 0, 7, 6 },
                                          { 6, 4, 7, 0, 6 },
                                          { 7, 4, 3, 4, 0 } };

            int[,] res = ds.Calculate(matrix);

            CollectionAssert.AreEqual(wait, res);
        }
    }
}