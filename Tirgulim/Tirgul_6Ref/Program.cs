namespace Tirgul_6Ref
{
    /*Задание:
     * Напиши метод Swap, который принимает две переменные int по ref и меняет их местами.
     * Пример вызова:
     * int a = 3, b = 7;
     * Swap(ref a, ref b); // a станет 7, b станет 3
   */
    internal class Program
    {
        static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Tirgul_6Ref");

            int a = 3;
            int b = 7;
            Swap(ref a, ref b);
            Console.WriteLine("The a = " + a); // → 7
            Console.WriteLine("The b = " + b); // → 3
        }
    }
}