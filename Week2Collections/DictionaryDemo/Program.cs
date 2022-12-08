

List<string> letters = new List<string>();

letters.Add("Abc");
letters.Add("def");
letters.Add("Ghi");
letters.Add("Jkl");
letters.Add("Mno");

Console.WriteLine("Here are the letters");
foreach(var next in letters)
{
    Console.WriteLine(next);
}



Dictionary<string, string> foods = new Dictionary<string, string>();
foods["Paul"] = "Spaghetti";
foods["Sarah"] = "Pizza"; 
foods["Ruby"] = "Ice Cream"; 
foods["Quincy"] = "Tacos";
foods["Terry"] = "Tacos";
Console.WriteLine();
Console.WriteLine(foods["Ruby"]);
Console.WriteLine();
//Paul changed his mind. He likes hamburgers. 
foods["Paul"] = "Hamburgers";
Console.WriteLine($"Paul now likes {foods["Paul"]}");

foreach(var pair in foods)
{
    Console.WriteLine("The name and the food are: ");
    Console.WriteLine(pair.Key); //The person's name
    Console.WriteLine(pair.Value); //Their favorite food 
}

//Check to see if an item exists in a dictionary 
string entry = Console.ReadLine();
if (foods.ContainsKey(entry))
{
    Console.WriteLine($"Yes, we have a favorite food for {entry}");
    Console.WriteLine(foods[entry]);
}
else
{
    Console.WriteLine($"We don't know that person.");
}

