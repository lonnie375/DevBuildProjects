// A dictionary of favorite numbers. 
// The key is the name of the person, so it's a string. 
// the value is that person's list of favorite numbers. So it's a list of int. 

Dictionary<string, List<int>> Favorites = new Dictionary<string, List<int>>();

Favorites["Paul"] = new List<int>() { 10, 100, 1000, 10000 };
Favorites["Sarah"] = new List<int>() { 2, 4, 6, 8, 10, 12, 14 };
Favorites["Quicny"] = new List<int>() { 1, 3 , 5, 7};
Favorites["Ruby"] = new List<int>() { 16, 38, 284, 8537, 17 };
Favorites["Terry"] = new List<int>() { 2, 2, 2, 2, 2 };

foreach (var item in Favorites)
{
    Console.WriteLine(item.Key);

    //we have to loop through the value because it is a List! 
    //We have to use the item.Value here to highlight that as well. 
    foreach (var item2 in item.Value)
    {
        Console.Write(item2[]);
    }
}