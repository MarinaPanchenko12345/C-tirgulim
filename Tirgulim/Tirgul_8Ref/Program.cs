namespace Tirgul_8Ref
{
    /*Подсчёт положительных, отрицательных и нулей
     * Задание:
     * Сделай метод CountNumbers, который принимает массив int и возвращает через ref:
     * кол - во положительных чисел,
     * кол-во отрицательных,
     * кол - во нулей.
     * Пример вызова:
     *     int[] arr = { -3, 0, 7, -1, 0, 2 };
     *     int pos = 0, neg = 0, zero = 0;
     *     CountNumbers(arr, ref pos, ref neg, ref zero);
     *     pos = 2, neg = 2, zero = 2
     */
    internal class Program
    {

        static void CountNumbers(int[] arr, ref int pos, ref int neg, ref int zero)
        {
            if (arr.Length == 0)
            {
                Console.WriteLine("Array is empty");
                return;
            }
            pos = 0 ;
            neg = 0 ;
            zero = 0 ;


            foreach (int item in arr)
            {
                if (item > 0)
                    pos ++;
                if (item < 0)
                    neg ++;
                if (item == 0) 
                zero ++;
            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Tirgul_8Ref");
            int[] arr = { -3, 0, 7, -1, 0, 2 };

            int pos = 0, neg = 0, zero = 0;

            CountNumbers(arr, ref pos, ref neg, ref zero);

            Console.WriteLine("pos: " + pos);
            Console.WriteLine("neg: " + neg);
            Console.WriteLine("zero: " + zero);


        }
    }
}