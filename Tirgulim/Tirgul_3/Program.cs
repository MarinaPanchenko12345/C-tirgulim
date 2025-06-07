namespace Tirgul_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculate");

            double firstNumber, secondNumber;
            string action;

            Console.WriteLine("Enter the first number ");
            firstNumber = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number ");
            secondNumber = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the operator ");
            action = Console.ReadLine();




            switch (action)
            {
                case "+":
                    Console.WriteLine("Resul is : " + (firstNumber + secondNumber));
                    break;
                case "-":
                    Console.WriteLine("Resul is : " + (firstNumber - secondNumber));
                    break;
                case "*":
                    Console.WriteLine("Resul is : " + (firstNumber * secondNumber));
                    break;
                case "/":
                    if (secondNumber == 0)
                    {
                        Console.WriteLine("Resul is : Error");
                    }
                    else
                    {
                        Console.WriteLine("Resul is : " + (firstNumber / secondNumber));

                    }
                    break;
                default:
                    Console.WriteLine("You entered an unknown symbol");
                    break;
            }
        }
    }
}