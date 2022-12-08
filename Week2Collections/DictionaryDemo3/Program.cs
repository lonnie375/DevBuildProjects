//Lets do a dictionary like this: 
// 1 "one 
//10 "ten" 
//20 "twenty" 
//100 "one hundred" 
// Ket is int 
// Value is string 
Dictionary<int , string> numToWord = new Dictionary<int, string>();

numToWord[1] = "One";
numToWord[10] = "Ten";
numToWord[20] = "Twenty";
numToWord[100] = "One Hundred";

Console.WriteLine("Here are the keys: ");
foreach(var word in numToWord)
{
    Console.WriteLine($"{word.Key}");
    
}

Console.WriteLine();
Console.WriteLine("Here are the values ");
foreach(var word in numToWord)
{
    Console.WriteLine($"{word.Value}");
}