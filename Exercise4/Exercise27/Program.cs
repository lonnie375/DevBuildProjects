//Prompt the user to enter text.  Count and output how many consonants are in the string.



bool proceed = true;
while (proceed)
{
    int vowelCounter = 0;
    int consonants = 0;
    Console.Write("Enter some text: ");
    string input = Console.ReadLine().ToLower();

    for (int i = 0; i < input.Length; i++)
    {
        if (input[i] == 'a' || input[i] == 'e' || input[i] == 'i' || input[i] == 'o' || input[i] == 'u')
        {
            vowelCounter++;
        }
        else if (input[i] == 'b' || input[i] == 'c' || input[i] =='d' || input[i] == 'f' || input[i] == 'g' || input[i] == 'h' || input[i] == 'j' || input[i] == 'k'|| input[i] == 'l' || input[i] == 'm' || input[i] == 'n' || input[i] == 'p' || input[i] == 'q' || input[i] == 'r' || input[i] == 's' || input[i] == 't'|| input[i] == 'v' || input[i] == 'w' || input[i] == 'x' || input[i] == 'y' || input[i] == 'z')
        {
            consonants++;
        }

    }
    Console.WriteLine($"There are {consonants} consonants.");

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