using System;

namespace DictionaryPractice4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dictionary Practice4");

            /*Creating and Adding*/
            Console.WriteLine("Creating and Adding");
            Dictionary<string,int> ages= new Dictionary<string,int>();
            ages.Add("Alicee", 30);
            ages.Add("Bob", 25);
            Console.WriteLine(ages["Bob"]);

            /*Updete by key*/
            Console.WriteLine("\n\nUpdete by key");
            Dictionary<string, string> capitals = new Dictionary<string, string>()
            {
                {"France" , "Paris" },
                {"Germany" , "Berlin" }
            };

            capitals["Germany"] = "Munich";
            Console.WriteLine("Capital of Germany : " + capitals["Germany"]);


            /*Loop for Dictionary*/
            Console.WriteLine("\n\nForeach for Dictionary");
            Dictionary<int, string> products = new Dictionary<int, string>()
            {
                {1,"Phone" },
                {2,"Laptop" }
            };
            foreach (var item in products) 
            {
                Console.WriteLine($"ID: {item.Key} , Name: {item.Value}");
            }


            /*Create Dictionary with 3 students , and print grade of one*/
            Console.WriteLine("\n\nCreate Dictionary with 3 students , and print grade of one");
            Dictionary<string, int> students = new Dictionary<string, int>();
            students.Add("Simon", 90);
            students.Add("Anna", 85);
            students.Add("Bob", 70);
            Console.WriteLine("Grade of Simon is :" + students["Simon"]);


            /*Change value of one of key, for example age*/
            Console.WriteLine("\n\nChange value of one of key");
            Dictionary<string, int> age = new Dictionary<string, int>()
            {
                {"Fany" ,25 },
                { "Bob" , 32}
            };
            foreach(var a in age)
            {
                Console.WriteLine($"Name : {a.Key} , Age: {a.Value}");
            }
           

            Console.WriteLine("\n\nAge after changes :");
            age["Fany"] = 36;
            foreach (var a in age)
            {
                Console.WriteLine($"Name : {a.Key} , Age: {a.Value}");
            }


            /*Dictionary of capitals of Countries*/
            Console.WriteLine("\n\nDictionary of capitals of Countries");
            Dictionary<string, string> captowns = new Dictionary<string, string>()
            {
                {"France" , "Paris" },
                {"Germany" , "Berlin" },
                {"Canada" , "Ottava" },
                {"Australiya" , "Sidney" },
                {"Israel" , "Erushalim" }
            };
            foreach (var cap in captowns)
            {
                Console.WriteLine($"Capital of {cap.Key} is {cap.Value}");
            }


        }
    }
}
