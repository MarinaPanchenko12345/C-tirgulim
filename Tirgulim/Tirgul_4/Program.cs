using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Tirgul_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter something:");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int intValue))
            {
                Console.WriteLine("Type: int");
            }
            else if (double.TryParse(input, out double doubleValue))
            {
                Console.WriteLine("Type: double");
            }
            else if (bool.TryParse(input, out bool boolValue))
            {
                Console.WriteLine("Type: bool");
            }
            else
            {
                Console.WriteLine("Type: string");
            }
        }
    }
}
//out используется, чтобы возвращать значения из метода через параметры.
//    Когда метод должен вернуть больше одного значения
//(а в C# метод может возвращать только один return напрямую).

//    int number;
//bool success = int.TryParse("123", out number);
//TryParse пытается преобразовать строку "123" в int

//Если получается — возвращает true и записывает значение в переменную number

//Если не получается — возвращает false, а number остаётся по умолчанию
//Что делает out?
//Говорит компилятору: "Эта переменная будет заполнена внутри метода"

//Ты не обязан(а) присваивать number до вызова — потому что метод TryParse сам присвоит ей значение