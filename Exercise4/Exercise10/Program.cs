//Determine whether the user is tall enough to ride a roller coaster. Prompt the user to enter her height in inches.
//If she is less than 54 inches tall, notify her that she cannot ride the Raptor.
//If she is at least 54 inches tall, notify her that she can ride the Raptor.
bool again = true;

while (again)
{
    Console.Write("Enter your height in inches: ");
string input = Console.ReadLine();
int userHeight; 
bool correct = int.TryParse(input, out userHeight);
bool proceed = true;

    while (!proceed)
    {
        if (correct)
        {
            proceed = true;
        }
        else
        {
            Console.Write("Please enter your height in inches: ");
            input = Console.ReadLine();
            correct = int.TryParse(input, out userHeight);
        }
    }


    if (userHeight < 54)
    {
        Console.WriteLine($"Sorry you cannot ride the Raptor. You need {54 - userHeight} more inches");
    }
    else
    {
        Console.WriteLine("Great, you can ride the Raptor!");
    }

    Console.Write("Would you like to continue? (y/n): ");
    string userChoice = Console.ReadLine();

    if (userChoice == "y" || userChoice == "yes")
    {

    }
    else
    {
        Console.WriteLine("Good Bye!");
        again = false;
    }

}
