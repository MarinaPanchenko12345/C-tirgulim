namespace TypeConversion1
{
    /* 2.1. Преобразуй int в double
     * int → double и выведи результат.
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("TypeConversion1");

            int a = 4;

            double result = Convert.ToDouble(a);
            Console.WriteLine(result);
        }
    }
}