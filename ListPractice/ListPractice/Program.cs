

namespace ListPractice
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            String[] food = new string[3];

            food[0] = "pizza";
            food[1] = "humburger";
            food[2] = "hotdog";
            food[3] = "frise";


            foreach (var item in food)
            {
                Console.WriteLine( item );
            }


            Console.ReadKey();
        }
    }
}
