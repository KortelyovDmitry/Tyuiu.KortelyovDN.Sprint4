using Tyuiu.KortelyovDN.Sprint4.Task0.V12.Lib;

namespace Tyuiu.KortelyovDN.Sprint4.Task0.V12
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int[] numsArray = { 4, 6, 2, 8, 4, 5, 6, 9, 8, 7 };

            Console.WriteLine("Массив:");
            for (int i = 0; i < numsArray.Length; i++)
            {
                Console.Write(numsArray[i] + "\t");
            }
            Console.WriteLine();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int res = ds.GetMultEvenArrEl(numsArray);

            Console.WriteLine("Произведение четных элементов массива = " + res);
            Console.ReadKey();
        }
    }
}