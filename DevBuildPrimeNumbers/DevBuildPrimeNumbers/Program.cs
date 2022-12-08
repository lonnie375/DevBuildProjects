using DevBuildPrimeNumbers;

Console.WriteLine("Let's locate some primes!");
Console.WriteLine();
Console.WriteLine("This application will find you any prime, in order, from first prime number to 25.");
Console.WriteLine();

bool proceed = true;
while (proceed)
{
    Console.Write("Where on our prime list do you want to explore? ");
    int userInput = int.Parse(Console.ReadLine());

    GetPrime selection = new GetPrime();
    selection.GetPrimeNumber(userInput);

    Console.Write($"Do you want to find another prime number? (y/n): ");
    string repeat = Console.ReadLine().ToLower(); 

    if (repeat == "y")
    {

    }
    else
    {
        Console.WriteLine("Goodbye");
        proceed = false; 
    }
}


