namespace TypeVariables3
{
    /* 1.3. Выведи символ и его код
     * Дано: символ char.
     * Найти: числовой код с помощью Convert.ToInt32(char).
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("TypeVariables3");

            char a = '5';

            int result = Convert.ToInt32(a);

            Console.WriteLine($"Symbol: {a}");
            Console.WriteLine($"Code of symbol: {result}");


        }
    }
}