//Prompt the user for a number. Use a for loop to output all the numbers from that number to 0.

bool proceed = true; 
while (proceed)
{
    Console.Write("Enter a number: ");
    string input = Console.ReadLine();
    int userNumber; 
    bool correct = int.TryParse(input, out userNumber);
    while (!correct)
    {
        Console.Write("Please enter a number: ");
        input = Console.ReadLine();
        correct = int.TryParse(input, out userNumber);
    }

    for (int i = userNumber; i >= 0; i--)
    {
        Console.Write(i);
    }

    Console.WriteLine();
    Console.WriteLine();
    Console.Write("Would you like to continue? (y/n)");
    string userChoice = Console.ReadLine().ToLower(); 

    if (userChoice == "y" || userChoice == "yes")
    {

    }
    else
    {
        Console.WriteLine("Good Bye!");
        proceed = false;
    }

}