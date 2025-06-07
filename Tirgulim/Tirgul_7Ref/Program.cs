namespace Tirgul_7Ref
{
    /*Минимум и максимум из массива
     * Задание:
     * Создай метод FindMinMax, который принимает массив int и
     * возвращает минимум и максимум через ref переменные.
     * csharp
     * Copy
     * Edit
     * Пример вызова:
     *      int[] arr = { 4, 2, 9, 1, 6 };
     *      int min = 0, max = 0;
     *      FindMinMax(arr, ref min, ref max);
     *      min = 1, max = 9
     */
    internal class Program
    {
        static void FindMinMax(int[] arr, ref int min, ref int max)
        {
            if (arr.Length == 0)
            {
                Console.WriteLine("Array is empty!");
                return;
            }

            min = arr[0];
            max = arr[0];

            foreach (int number in arr)
            {
                if (number < min)
                    min = number;
                if (number > max)
                    max = number;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Tirgul_7Ref");

            int[] arr = { 4, 2, 9, 1, 6 };
            int min = 0;
            int max = 0;

            FindMinMax(arr, ref min, ref max);

            Console.WriteLine("min: " + min);
            Console.WriteLine("max: " + max);
        }
    }
}