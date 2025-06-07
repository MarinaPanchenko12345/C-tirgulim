namespace TypeConversion3
{
    /* 2.3. Преобразуй строку "123" в число
     * Используй int.Parse() или Convert.ToInt32().
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("TypeConversion3");

            string str = "123";

            int a = int.Parse(str);
            Console.WriteLine(a);

        }
    }
}