//Prompt the user to enter a number.  Use a for-loop to calculate the product of the number and the two preceding numbers.
bool proceed = true;

while (proceed)
{

    Console.Write("Enter a number: ");
    string input = Console.ReadLine();
    int userNumber;
    bool correction = int.TryParse(input, out userNumber);

    while (!correction)
    {
        Console.Write("Please enter a number: ");
        input = Console.ReadLine();
        correction = int.TryParse(input, out userNumber);
    }

    int product = 1;
    for (int i = userNumber; i >= userNumber - 2; i--)
    {
        product *= i;

    }
    Console.WriteLine($"The product of {userNumber} , {userNumber - 1}, and {userNumber - 2} is {product}");

    Console.Write("Would you like to continue (y/n)? ");
    string userInput = Console.ReadLine().ToLower();

    if (userInput == "y" || userInput == "yes")
    {

    }
    else
    {
        Console.WriteLine("GoodBye!");
        proceed = false;
    }
}