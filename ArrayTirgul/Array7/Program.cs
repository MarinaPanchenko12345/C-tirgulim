namespace Array7
{
    /* Найти наименьшее число в массиве */
    /* Написать программу которая находит наименьшее число в массиве. */
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Home Work */
            Console.WriteLine("Home Work");
            Console.Write("Enter the number of array elements :\t ");

            int elementsCount = int.Parse(Console.ReadLine());

            int[] myArray = new int[elementsCount];

            int minNum = 100;

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write($"Enter element with index {i} : ");
                myArray[i] = int.Parse(Console.ReadLine());

                if (myArray[i] < minNum)
                {
                    minNum = myArray[i];
                }

            }
            Console.WriteLine($"\nMinimum number is: {minNum}");



            /*Class Home Work */
            Console.WriteLine("\nClass Home Work");

            int[] myArray2 = { 2, 1, 6, 8, 7, 77, 88, 99 };
            int minValue = myArray2[0];

            for (int x = 0; x < myArray2.Length; x++) //x=1
            {
                Console.WriteLine(myArray2[x]);
                if (myArray2[x] < minValue)
                {
                    minValue = myArray2[x];
                }
            }
            Console.WriteLine($"\nMinimum number is : {minValue}");


            Console.ReadLine();
        }
    }
}