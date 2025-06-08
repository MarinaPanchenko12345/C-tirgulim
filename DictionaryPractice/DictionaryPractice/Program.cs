Console.WriteLine("Dictionary");

Dictionary<int, string> rookOfTheYear = new();

rookOfTheYear.Add(2000, "james William Smith");
rookOfTheYear.Add(2001, "Olivia Emma Johnson");
rookOfTheYear.Add(2002, "Liam Noah Brown");
rookOfTheYear.Add(2003, "Liam Noah Brown");
rookOfTheYear.Add(2004, "Sophia Mia Taylor");
Console.WriteLine(rookOfTheYear[2002]);



Dictionary<string, List<string>> wishlist = new();

wishlist.Add("William Smith", new List<string> { "Xbox","Tesla","Pizza"});
wishlist.Add("Olivia Emma", new List<string> { "PS5","Ford","Apple"});
wishlist.Add("Sophia Mia", new List<string> { "PS8","Ford","Apple"});
wishlist.Add("Mia Taylor", new List<string> { "PS","Ford","Apple"});
wishlist.Add("Noah Brown", new List<string> { "PS1","Ford","Apple"});

foreach (var (key,value) in wishlist)
{
    Console.WriteLine($"{key}'s wishlist : ");

    foreach (var item in value) 
    {
        Console.WriteLine($"\t{item}");
    }
    
}
Console.WriteLine(wishlist["Olivia Emma"][0]);
