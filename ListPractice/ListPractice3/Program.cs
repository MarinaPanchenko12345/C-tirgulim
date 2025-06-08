namespace ListPractice3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("List Practice3");

            /*Create and Add elements*/
            Console.WriteLine("\n\nList of fruits");
            List<string> fruits = new List<string>();
            fruits.Add("Apple");
            fruits.Add("Banana");
            fruits.Add("Orange");
            foreach (string fruit in fruits)
            {
                Console.WriteLine(fruit);
            }

            /**/
            List<int> numbers = new List<int> { 10, 20, 30 };
            numbers[1] = 25;
            Console.WriteLine("\n\nChange 20 to :" + numbers[1]);


            /*Delete and count*/
            List<string> names = new List<string> { "Anna", "Bella", "Tom" };
            names.Remove("Tom");
            Console.WriteLine("\n\nCount: " + names.Count);


            /*Create list of numbers 1-5*/
            Console.WriteLine("\n\nList of numbers");
            List<int> five = new List<int> { 1, 2, 3, 4, 5 };
            foreach (int fiveit in five)
            {
                Console.WriteLine(fiveit);
            }


            /*Chenge second element to "Update"*/
            Console.WriteLine("\n\nChange Delete to Update");
            List<string> words = new List<string> { "Can", "You", "Delete", "Me", "?" };
            words[2] = "Update";
            foreach (string word in words)
            {
                Console.WriteLine(word);
            }
            Console.WriteLine("Change Delete to :" + words[2]);

            /*Delete last element from list and print list.lenght*/
            List<int> nums = new List<int> { 1, 2, 3, 4, 5, 25 };
            Console.WriteLine("\n\nNumbers of list");
            foreach (int num in nums)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine("Removed number is :" + nums.Remove(25));

            Console.WriteLine("\n\nNumbers of new list");
            foreach (int num in nums)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine("\n\nCount of new list: " + nums.Count);

        }
    }
}
