using Tyuiu.KortelyovDN.Sprint4.Task6.V17.Lib;

namespace Tyuiu.KortelyovDN.Sprint4.Task6.V17
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string[] varArray = { "Python", "JavaScript", "Java", "C#", "Swift", "Kotlin", "Ruby" };

            Console.WriteLine("Исходный массив:");
            for (int i = 0; i < varArray.Length; i++)
            {
                Console.WriteLine(varArray[i]);
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int res = ds.Calculate(varArray);

            Console.WriteLine("Количество элементов, длина которых равна 6 = " + res);
            Console.ReadKey();
        }
    }
}