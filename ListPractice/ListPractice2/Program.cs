namespace ListPractice2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("List Practice 2");


            List<String> food = new List<String>();

            food.Add("pizza");
            food.Add("humburger");
            food.Add("hotdog");
            food.Add("frise");

            //food.Remove("frice");
            //food.Insert(0,"sushi");
            //Console.WriteLine(food.Count);
            //Console.WriteLine(food.IndexOf("pizza"));
            //Console.WriteLine(food.LastIndexOf("frise"));
            //Console.WriteLine(food.Contains("pizza"));
            //food.Sort();
            food.Reverse();
            //food.Clear();

            String[] foodArray=food.ToArray();



            foreach (String item in food)
            {
                Console.WriteLine( item);
            }

            Console.WriteLine( );
        }
    }
}
