using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.KortelyovDN.Sprint4.Task7.V30.Lib
{
    public class DataService : ISprint4Task7V30
    {
        public int Calculate(int rows, int columns, string value)
        {
            int[,] mtrx = new int[rows, columns];
            int itog = 1;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    mtrx[i, j] = int.Parse(value.Substring(i * columns + j, 1));

                    if (mtrx[i, j] % 2 == 0)
                    {
                        itog *= mtrx[i, j];
                    }
                }
            }
            return itog;
        }
    }
}