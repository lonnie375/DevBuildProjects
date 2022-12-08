//Prompt the user to enter text.  Remove all the vowels and output the text.

bool proceed = true;
while (proceed)
{
    string vowels = "aeiou"; 
    Console.Write("Enter some text: ");
    string input = Console.ReadLine().ToLower();

    string userInput = new string(input.Where(x => !vowels.Contains(x)).ToArray());

    Console.WriteLine($"{userInput}");

    Console.Write("Would you like to continue (y/n)? ");
    string userChoice = Console.ReadLine().ToLower();

    if (userChoice == "y")
    {

    }
    else
    {
        Console.WriteLine("GoodBye");
        proceed = false;
    }
}