//Repeatedly prompt the user to enter a string.  Store the string in a list and display the contents of the list with each element separated by a space.

List<string> userInput = new List<string>();

bool proceed = true;

while (proceed)
{
    Console.Write("Enter some text: ");
    string input = Console.ReadLine().ToLower();

    userInput.Add(input);

    Console.Write("Would you like to continue (y/n)? ");
    string userResponse = Console.ReadLine().ToLower();
    if (userResponse == "y")
    {

    }
    else
    {
        proceed = false;
        
    }
}

foreach(string input in userInput)
{
    Console.Write(" " + input);
}

