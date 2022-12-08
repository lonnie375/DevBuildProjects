//Prompt the user to enter a string. After the user enters a string, output the same string back to the console 
Console.Write("Enter some text: ");
string userInput = Console.ReadLine();

while (string.IsNullOrEmpty(userInput) || string.IsNullOrWhiteSpace(userInput))
{
    Console.WriteLine("Please enter some text");
    userInput = Console.ReadLine();
}

    Console.WriteLine(userInput);

