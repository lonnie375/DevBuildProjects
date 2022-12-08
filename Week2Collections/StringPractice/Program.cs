string sentence = "Hello there everybody from planet earth!"; 
string[] words = sentence.Split(" ");

foreach (string word in words)
{
    Console.WriteLine(word);
}
Console.WriteLine();
sentence = "Hello,there,everybody,from,planet,earth!"; 
words = sentence.Split(',');

foreach(string word in words)
{
    Console.WriteLine(word);
}
Console.WriteLine();
char[] delims = { ','     ,      ' ' }; //split by coma or space 
words = sentence.Split(delims);
foreach(string word in words)
{
    Console.WriteLine(word);
}

//Lets join these words back together. 
sentence = string.Join(" ", words);
Console.WriteLine(sentence);

//Methods that are attached to the type itself are called "static" methods
//Methods that are attached to an instance of the type (such as sentecn) are called instance methods. 

//Lets find the position of a letter in a string. 
// IndexOf uses a common approach: it returns a 0-based index, or -1 if it doesn't find it. 

sentence = "We will find a letter position.";
Console.WriteLine(sentence.IndexOf('i'));
Console.WriteLine(sentence.IndexOf('x'));
Console.WriteLine(sentence.LastIndexOf('i'));
Console.WriteLine(sentence.LastIndexOf('x'));

//Substrings 
Console.WriteLine();
Console.WriteLine("Substring practice");
sentence = "Hello World";
Console.WriteLine(sentence.Substring(1)); //Expect "ello world"
Console.WriteLine(sentence.Substring(3));// Expect "lo world" 
Console.WriteLine(sentence.Substring(4,3)); // Expect "o W" 