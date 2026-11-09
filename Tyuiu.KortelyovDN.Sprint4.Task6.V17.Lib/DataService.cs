using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.KortelyovDN.Sprint4.Task6.V17.Lib
{
    public class DataService : ISprint4Task6V17
    {
        public int Calculate(string[] array)
        {
            string[] filteredArray = Array.FindAll(array, x => x.Length == 6);

            return filteredArray.Length;
        }
    }
}