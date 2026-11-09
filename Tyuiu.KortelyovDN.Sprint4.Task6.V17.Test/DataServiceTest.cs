using Tyuiu.KortelyovDN.Sprint4.Task6.V17.Lib;

namespace Tyuiu.KortelyovDN.Sprint4.Task6.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            string[] varArray = { "Python", "JavaScript", "Java", "C#", "Swift", "Kotlin", "Ruby" };

            int res = ds.Calculate(varArray);

            int wait = 2;

            Assert.AreEqual(wait, res);
        }
    }
}