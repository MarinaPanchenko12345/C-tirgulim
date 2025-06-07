using System;

namespace Tirgul_5Ref
{
    /*Увеличь значение переменной
     * Задание:
     * Создай метод AddFive, который принимает int переменную по ref и добавляет к ней 5.
     * Пример вызова:
                   int num = 10;
/                  AddFive(ref num); // num станет 15
    */
    internal class Program
    {
        static void AddFive(ref int num)
        {
            num = (num + 5);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Tirgul_5Ref");

            int num = 10;
            AddFive(ref num);
            Console.WriteLine(num);

        }
    }
}
/*ref (от reference) позволяет передавать переменные по ссылке в метод.
 * Это значит, что метод может изменить значение переменной вне метода — как будто работает с оригиналом.
 *  Без ref переменная передаётся по значению — создаётся копия,
 *  и изменения внутри метода не влияют на оригинал.
 *  
 *  С ref метод получает ссылку на оригинальную переменную, и может её изменить.
 *      Пример без ref:
                static void SetToTen(int number)
            {
               number = 10;
          }

          static void Main()
           {
                int x = 5;
               SetToTen(x);
               Console.WriteLine(x);  // Выведет: 5
           }

           Пример с ref:
           static void SetToTen(ref int number)
           {
               number = 10;
           }

           static void Main()
           {
               int x = 5;
               SetToTen(ref x);
               Console.WriteLine(x);  // Выведет: 10
           }
 *  
 *   Переменная должна быть инициализирована до передачи:
 *   Метод должен явно указать ref в определении и в вызове:
 *     void MyMethod(ref int num)  // ← здесь ref
 *     MyMethod(ref x);            // ← и здесь ref
 *  
 *  
 *   Когда тебе нужно изменить значение переменной внутри метода
 *  Или вернуть несколько значений(альтернатива к out, но с обязательной инициализацией до переда
 */
         








