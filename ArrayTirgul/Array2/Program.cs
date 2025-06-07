namespace Array2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Array2");
            /*******************/
            /*lenght of array***/
            /*******************/
            Console.WriteLine("Find lenght of array");

            int[] numbers2 = { 5, -5, 0, -10, 15, 105, 808 };

            Console.WriteLine($"Lenght of Array is : {numbers2.Length}");


            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            foreach (string i in cars)
            {
                Console.WriteLine(i);
            }

            Console.ReadLine();
        }
    }
}
