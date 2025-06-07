namespace Array6
{
    /* Найти сумму чётных чисел в массиве */
    /* Написать программу которая находит сумму чётных чисел в массиве.*/
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Array6");
            /*first variant*/
            Console.WriteLine("Enter the number of array elements :");
            int elementsCount= int.Parse(Console.ReadLine());

            int[] myArray = new int[elementsCount];

            int sum= 0;

            for(int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine($"Enter the number with index {i} number");
                myArray[i] = int.Parse(Console.ReadLine());

                if( myArray[i] %2==0 )
                {
                    sum += myArray[i];
                }

            }
            Console.WriteLine($"\nSum of even numbers: {sum}");


            /*second variant*/
            int[] myArray2 = { 2, 5, 9, -1, 9, 8, 2 };
            int result = 0;

            for (int y = 0;y < myArray2.Length;y++)
            {
                Console.WriteLine(myArray2[y]);
                if (myArray2[y] % 2 == 0)
                {
                    result += myArray2[y];
                }
            }
            Console.WriteLine($"\nSum of even numbers: {result}");
        }
    }
}
