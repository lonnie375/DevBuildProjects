//Prompt the user to enter a number.  Use a for-loop to calculate the sum of all the numbers from 1 to the number entered.
bool proceed = true; 
while (proceed)
{
    Console.Write("Enter a number: ");
    string input = Console.ReadLine();
    int userNumber;
    bool correction = int.TryParse(input, out userNumber);
    int sum = 0;
    double avg;
    while (!correction)
    {
        Console.Write("Please enter a number: ");
        input = Console.ReadLine();
        correction = int.TryParse(input, out userNumber);
    }

    for (int i = 1; i <= userNumber; i++)
    {
        sum += i;

        Console.WriteLine(sum);
    }

    Console.Write("Would you like to continue (y/n)?");
    string userInput = Console.ReadLine();
    if (userInput == "y" || userInput == "yes")
    {

    }
    else
    {
        Console.WriteLine("GoodBye");
        proceed = false;
    }
}
