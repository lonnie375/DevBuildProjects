// An array is a variable that can hold a list of things 

//int[] grades = { 100, 80, 100, 60, 80 };

//Console.WriteLine(grades[0]);
//Console.WriteLine(grades[1]);
//Console.WriteLine(grades[4]);


string[] names = { "Fred", "Jamal", "Yasmine", "Ziggy" };
Console.WriteLine(names[0]);
Console.WriteLine(names[2]);

Console.WriteLine();
int index = 3;

Console.WriteLine();
    for(int ind = 0; ind < 4; ind++)
{
    Console.WriteLine(names[ind]);
}
    foreach(string name in names)
{
    Console.WriteLine(name);    
}

// We're actually chaning the entire string, replacing it. Strings are immutable. We can't change an individual letter. 
names[2] = "Jasmine";
Console.WriteLine($"We corected the spelling of {names[2]}");


string test = "hello";
Console.WriteLine(test[0]);
//test[0] = "a"; can't run becaue you can't change a string

