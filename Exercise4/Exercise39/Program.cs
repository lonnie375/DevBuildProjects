//Prompt the user to enter five numbers.  Store these numbers in an array and output their average.

int[] userSum = new int[5];

bool proceed = true;

while (proceed)
{
    Console.Write("Enter a number: ");
    int firstNumber = int.Parse(Console.ReadLine());

    userSum[0] = firstNumber;

    Console.Write("Enter a number: ");
    int secondNumber = int.Parse(Console.ReadLine());

    userSum[1] = secondNumber;

    Console.Write("Enter a number: ");
    int thirdNumber = int.Parse(Console.ReadLine());

    userSum[2] = thirdNumber;

    Console.Write("Enter a number: ");
    int fourthNumber = int.Parse(Console.ReadLine());

    userSum[3] = fourthNumber;

    Console.Write("Enter a number: ");
    int fifthNumber = int.Parse(Console.ReadLine());

    userSum[4] = fifthNumber;

    Array.Sort(userSum);

    foreach(int sum in userSum)
    {
        Console.Write(String.Format("{0} ", sum));
    }
    Console.WriteLine();
    Console.Write("Would you like to continue (y/n)? ");
    string userInput = Console.ReadLine().ToLower();

    if (userInput == "y")
    {

    }
    else
    {
        proceed = false;
        Console.WriteLine("GoodBye!");
    }
}
