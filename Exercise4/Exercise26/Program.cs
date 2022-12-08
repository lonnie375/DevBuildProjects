//Prompt the user to enter text.  Count and output how many vowels are in the string.



bool proceed = true;
while (proceed)
{
    int vowelCounter = 0;
    Console.Write("Enter some text: ");
    string input = Console.ReadLine().ToLower();

    for (int i = 0; i < input.Length; i++)
    {
        if (input[i] == 'a' || input[i] == 'e' || input[i] == 'i' || input[i] == 'o' || input[i] == 'u')
        {
            vowelCounter++;
        }
        else
        {

        }

    }
    Console.WriteLine($"There are {vowelCounter} vowels.");

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