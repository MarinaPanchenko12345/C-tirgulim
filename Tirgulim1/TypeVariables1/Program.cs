namespace TypeVariables1
{
    /*1.1. Объяви переменные всех базовых типов и выведи их
     * Цель: потренироваться с int, double, char, string, bool.
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("TypeVariables1");

            int a = 5;
            double b = 5.5;
            char c= 'a';
            string str = "Hello";
            bool d = false;

            Console.WriteLine($"a = {a}\t b= {b}\t c= {c}\t str = {str}\t bool = {d}");
        }
    }
}