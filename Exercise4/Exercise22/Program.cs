//Prompt the user to enter two numbers that will determine a range.  Then prompt the user to enter another number and check if it is in the range.


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

Console.Write("Enter another number: "); 
string secondInput = Console.ReadLine();
int secondNumber; 
bool secondCorrection = int.TryParse(secondInput, out secondNumber);

while (!secondCorrection)
{
    Console.Write("Please enter another number: "); 
    secondInput = Console.ReadLine();
    secondCorrection = int.TryParse(secondInput, out secondNumber);
}

Console.WriteLine($"Your range is {userNumber} - {secondNumber}");

bool proceed = true; 
while (proceed)
{
    Console.Write("Enter a number to verify it is in the range: ");
    string inRange = Console.ReadLine();
    int inRangeNumber;
    bool rangeCorrection = int.TryParse(inRange, out inRangeNumber);

    while (!rangeCorrection)
    {
        Console.Write("Please a number to confirm that it is in range: ");
        inRange = Console.ReadLine();
        rangeCorrection = int.TryParse(inRange, out inRangeNumber);
    }

    if (inRangeNumber >= userNumber && inRangeNumber <= secondNumber)
    {
        Console.WriteLine($"{inRangeNumber} is in the range");
    }
    else
    {
        Console.WriteLine($"{inRangeNumber} is outside the range");
    }

    Console.Write("Would you like to continue (y/n)? ");
    string userChoice = Console.ReadLine().ToLower();

    if (userChoice == "y" || userChoice == "yes")
    {

    }
    else
    {
        Console.WriteLine("GoodBye!");
        proceed = false;
    }

}
