using Tyuiu.KortelyovDN.Sprint4.Task1.V23.Lib;

namespace Tyuiu.KortelyovDN.Sprint4.Task1.V23
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int len = 17;
            int[] numsArray = new int[len];

            for (int i = 0; i < len; i++)
            {
                Console.Write("Введите значение " + i + " элемента массива (от 4 до 9): ");
                numsArray[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine();
            Console.WriteLine("Массив:");
            for (int i = 0; i < numsArray.Length; i++)
            {
                Console.Write(numsArray[i] + "\t");
            }
            Console.WriteLine();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int res = ds.Calculate(numsArray);

            Console.WriteLine("Сумма четных элементов массива = " + res);
            Console.ReadKey();
        }
    }
}