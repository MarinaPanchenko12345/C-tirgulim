namespace Array5
{
    /* Вывод элементов массива в обратном порядке */
    /* Написать программу выводящую на консоль элементы массива в обратном порядке. */
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Home Work */
            Console.WriteLine("Home Work");
            Console.Write("Enter the number of array elements :\t ");

            int elementsCount = int.Parse(Console.ReadLine());

            int[] myArray = new int[elementsCount];

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write($"Enter element with index {i} : ");
                myArray[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Your Array is : ");
            for (int i = elementsCount - 1; i >= 0; i--) // сдвиг из-за начала индекса с нуля
            {
                Console.WriteLine(myArray[i]);
            }


            /* Class Home Work */
            Console.WriteLine("Class Home Work");

            int[] myArray1 = { 10, 3, 2, 55 };

            for (int y = myArray1.Length - 1; y >= 0; y--) // сдвиг из-за начала индекса с нуля
            {
                Console.WriteLine(myArray1[y]);
            }



            Console.ReadLine();


        }
    }
}
