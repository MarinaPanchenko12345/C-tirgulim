namespace TypeConversion4
{
    /* 2.4. Преобразуй bool в строку
     * bool isActive = true;
     * string text = isActive.ToString();  // "True"
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("TypeConversion4");
            bool isActive = true;

            string text = isActive.ToString();

            Console.WriteLine("Boolean value: " + isActive);
            Console.WriteLine("Like row: " + text);
        }
    }
}