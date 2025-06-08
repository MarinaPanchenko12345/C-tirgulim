namespace Array1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Array1");
            /*******************/
            /******With loop****/
            /*******************/
            Console.WriteLine("Create and access an array with loop");

            string[] colors = { "red", "green", "blue", "orange", "pink" };

            int i;

            for (i = 0; i < colors.Length; i++)
            {
                Console.WriteLine(colors[i]);
            }


            /*******************/
            /***without loop****/
            /*******************/
            Console.WriteLine("\n\nCreate and access an array without loop");
            double[] numbers = { 2.3, 5.6, 8.9, 9.1, 1.5, 5.3 };

            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers[2]);
            Console.WriteLine(numbers[3]);
            Console.WriteLine(numbers[4]);
            Console.WriteLine(numbers[5]);


            /*******************/
            /******Change el****/
            /*******************/
            Console.WriteLine("Change an array element");

            string[] words = { "Hello ", "My ", "Dear ", "Lovely ", "Friend ", "How ", "Are ", "You ", "?" };
            words[4] = "Cat";

            int x;

            for (x = 0; x <= words.Length; x++)
            {
                Console.WriteLine(words[x]);
            }


            /*******************/
            /*lenght of array***/
            /*******************/
            Console.WriteLine("Find lenght of array");

            int[] numbers2 = { 5, -5, 0, -10, 15, 105, 808 };

            Console.WriteLine($"Lenght of Array is : {numbers2.Length}");

            Console.ReadLine();
        }
    }
}
