namespace TypeConversion2
{
    /* 2.2. Преобразуй double в int
     * double → int и выведи, что получилось (обрати внимание на округление).
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("TypeConversion2");

            double a = 5.2;

            int result = Convert.ToInt32(a);

            Console.WriteLine(result);
           
        }
    }
}