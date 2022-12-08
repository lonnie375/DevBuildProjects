string[] names = { "Darren Williams", "Robert Smith", "Mark Powell", "Shawn Miller" }; 
int[] grades = { 95, 98, 85, 80, 70 };

for (int index = 0; index < 4; index++)
{
    Console.WriteLine($"{names[index]} has grade {grades[index]}");
}

Console.WriteLine();
Console.WriteLine($"There are {names.Length} students.");
for (int index = 0; index < names.Length; index++)
{
    Console.WriteLine($"{names[index]} has grade {grades[index]}.");
}

Console.WriteLine();
Console.Write("Please enter a number: ");
string entry = Console.ReadLine();

int num = int.Parse(entry);

Console.WriteLine($"{names[num]} has grade {grades[num]}");



//Console.WriteLine();
//Console.WriteLine("Please enter a number from 1 to 5.");
//string entry = Console.ReadLine();
//int num = int.Parse(entry);
//num--; //convert the number to an index 


//Version 2 
bool okay = false;
int newNum = 0;
while (!okay)
{
    Console.WriteLine();
    Console.WriteLine("Pleae enter a number from 1 to 5.");
    entry = Console.ReadLine();
    bool validNumber = int.TryParse(entry, out newNum);

    if (validNumber)
    {
        if (newNum >= 1 && newNum <= 5)
        {
            okay = true;    
        }
    }
}


if (okay)
{
    newNum--;
    Console.WriteLine($"{names[newNum]} has grade {grades[newNum]}");
}
