string[] myarray = { "abc", "def", "ghi" };

Console.WriteLine(myarray[0]);

foreach (var item in myarray)
{
    Console.WriteLine(item);
}

myarray[1] = "jkl";

foreach (var item in myarray)
{
    Console.WriteLine(item);
}

Console.WriteLine();

//lets do this with a list 
//new refers to us creating a new instance of the list. 
List<string> myarray2 = new List<string>();
myarray2.Add("abc");
myarray2.Add("def");
myarray2.Add("ghi");

foreach (var item in myarray2)
{
    Console.Write(string.Join(", ", item));
}

Console.WriteLine(myarray2[0]);
Console.WriteLine();

myarray2[1] = "jkl";
myarray2.Add("mno");

foreach (var item in myarray2)
{
    Console.WriteLine(item);
}
Console.WriteLine();
Console.WriteLine(); 

//delete one from the list 
string removearray = "jkl";
myarray2.RemoveAt(2);

foreach (var item in myarray2)
{
    Console.WriteLine(item);
}

Console.WriteLine();
Console.WriteLine();

myarray2.Add("love");
myarray2.Add("love");
myarray2.Add("love");
myarray2.Remove("mno");
foreach (string item in myarray2)
{
    Console.WriteLine(item);
}

Console.WriteLine();
Console.WriteLine();

myarray2.RemoveAll(x => x == "love");
foreach (var item in myarray2)
{
    Console.WriteLine(item);
}
Console.WriteLine();
//insert one into the list 

myarray2.Insert(0, "love");
foreach (var item in myarray2)
{
    Console.WriteLine(item);
}
Console.WriteLine();
Console.WriteLine();
myarray2.InsertRange(0, myarray);
foreach (var item in myarray2)
{
    Console.WriteLine(item);
}
Console.WriteLine();

//we'll look at the official documentation. 
//lets sort the information 
myarray2.Sort();
foreach (var item in myarray2)
{
    Console.WriteLine(item);
}


//lets check if one exists 
Console.Write("Type in a word and we'll see if it is in the list.");
string entry = Console.ReadLine();
int index = myarray2.IndexOf(entry); 

if (index >= 0)
{
    Console.WriteLine($"found {entry} at {index}");
}
else
{
    Console.WriteLine($"Sorry, {entry} is not in the list.");
}

Console.WriteLine("Let's initialize a list of integers.");
List<int> numbers = new List<int> { 5, 3, 8, 2};
foreach (var item in numbers)
{
    Console.WriteLine($"The next number is {item}");
}


