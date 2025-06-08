namespace Array4
{
    /* Ввод данных в массив с консоли */
    /* Написать программу которая будет заполнять массив целыми числами.
     * Пользователь вводит количество элементов в массиве и числа (элементы массива) с консоли.
     * После заполнения данные массива выводятся в консоль отдельным циклом.
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Array4");

            Console.WriteLine("Enter the number of array elements ");

            int number = int.Parse(Console.ReadLine());

            int[] myArray = new int[number];

            for (int i = 0; i < number; i++)
            {
                Console.Write($"Enter the  {i+1} element :");
                myArray[i] =int.Parse(Console.ReadLine());
            }

            for (int i = 0;i < myArray.Length; i++) 
            {
                Console.WriteLine(myArray[i]);
            }
        }
    }
}
