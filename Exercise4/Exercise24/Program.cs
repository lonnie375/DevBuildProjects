//Prompt the user to enter a string.  Extract and output the last ten characters of the string.

bool proceed = true;
while (proceed)
{


    Console.Write("Enter some text: ");
    string input = Console.ReadLine();

    Console.WriteLine(input.TakeLast(10).ToArray());


    Console.Write("Would you like to continue (y/n)? ");
    string userChoice = Console.ReadLine().ToLower();

    if (userChoice == "y")
    {

    }
    else
    {
        Console.WriteLine("GoodBye!");
        proceed = false;
    }
}
