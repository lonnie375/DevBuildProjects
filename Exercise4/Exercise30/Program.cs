//Prompt the user to enter text.  Reverse the text.

bool proceed = true;

while (proceed)
{
    Console.Write("Enter some text: ");
    string userInput = Console.ReadLine();

    char[] reverseInput = userInput.ToCharArray();
    Array.Reverse(reverseInput);
    Console.WriteLine(new string(reverseInput));

    Console.Write("Would you like to continue (y/n)? "); 
    string userChoice = Console.ReadLine();

    if (userChoice == "y")
    {

    }
    else
    {
        Console.WriteLine("Good Bye");
        proceed = false;
    }

}