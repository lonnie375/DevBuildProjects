//Prompt the user to enter two numbers.  Use a for-loop to calculate the sum of all the numbers from the first number entered to the second.
bool proceed = true; 
while (proceed)
{
    Console.Write("Enter a number: ");
    string firstInput = Console.ReadLine();
    int firstNumber;
    bool firstCorrection = int.TryParse(firstInput, out firstNumber);

    Console.Write("Enter another number: ");
    string secondInput = Console.ReadLine();
    int secondNumber;
    bool secondCorrection = int.TryParse(secondInput, out secondNumber);

    while (!firstCorrection || !secondCorrection)
    {
        Console.Write("Please Enter another number: ");
        firstInput = Console.ReadLine();
        firstCorrection = int.TryParse(firstInput, out secondNumber);

        Console.Write("Please Enter another number: ");
        secondInput = Console.ReadLine();
        secondCorrection = int.TryParse(secondInput, out secondNumber);
    }

    int sum = 0;
    if (firstNumber < secondNumber)
    {
        for (int i = firstNumber; i <= secondNumber; i++)
        {
            sum += i;
        }
        Console.WriteLine($"THe sum of all the numbers from {firstNumber} to {secondNumber} is {sum}");
    }
    else if (firstNumber > secondNumber)
    {
        int secondSum = 0;
        for (int i = secondNumber; i <= firstNumber; i++)
        {
            secondSum += i;
        }
        Console.WriteLine($"The sum of all the numbers from {secondNumber} to {firstNumber} is {secondSum}");
    }

    Console.Write("Would you like to continue (y/n)? ");
    string userChoice = Console.ReadLine();

    if (userChoice == "y" || userChoice == "yes")
    {

    }
    else
    {
        Console.WriteLine("Goodbye!");
        proceed = false; 
    }

}

