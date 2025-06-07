namespace TypeVariables2
{
    /* 1.2. Вычисли площадь прямоугольника
     * Дано: длина и ширина (double).
     * Найти: площадь = длина × ширина.
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("TypeVariables2");

            double lenght = 5.5;
            double width = 7.1;

            double result = lenght* width;

            Console.WriteLine(result);
        }
    }
}