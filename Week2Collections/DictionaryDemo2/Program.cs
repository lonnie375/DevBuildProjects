//More fun with dictionaries 

//A list of salaries. The key will be a person's name (string), 
//And the value will be the person's salary (decimal). 
Dictionary<string, decimal> Salaries = new Dictionary<string, decimal>();

Salaries["Paul"] = 65000m;
Salaries["Sarah"] = 100000m;
Salaries["Quincy"] = 80000m;
Salaries["Ruby"] = 60000m;
Salaries["Terry"] = 25000m;

Console.Write($"Please enter a name: ");
string name = Console.ReadLine();

if (Salaries.ContainsKey(name))
{
    Console.WriteLine($"{Salaries[name]}");
}
else
{
    Console.WriteLine("They aren't here for you.");
}

Console.WriteLine();
Console.WriteLine("We are going to print out the names only ");
foreach(var item in Salaries.Keys)
{
    Console.WriteLine(item);
}

Console.WriteLine();
Console.WriteLine("We are going to print the values only");
foreach(var item in Salaries.Values)
{
    Console.WriteLine(item);
}

Console.WriteLine("Lets print everything");
foreach(var item in Salaries)
{
    Console.WriteLine(item.ToString());
}

Console.Write("Please add a new employee. What is their name? ");
name = Console.ReadLine();
Console.Write("Please enter a salary: ");
string entry = Console.ReadLine();
decimal salary = decimal.Parse(entry); //adding the salary 
Salaries[name] = salary; //adding the name and salary 

Console.WriteLine("Here is everybody");
foreach(var pair in Salaries)
{
    Console.WriteLine($"{pair.Key} makes {pair.Value}");


}