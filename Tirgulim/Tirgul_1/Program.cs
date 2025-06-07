namespace Tirgul_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Variables");

            int age = 25;
            double salary = 4567.89;
            char grade = 'A';
            string name = "Igor";
            bool isActive = true;

            Console.WriteLine(age);
            Console.WriteLine(salary);
            Console.WriteLine(grade);
            Console.WriteLine(name);
            Console.WriteLine(isActive);


            Console.WriteLine($"Age: {age}, Salary: {salary}, Grade: {grade}, Name: {name}, Active: {isActive}");


        }
    }
}