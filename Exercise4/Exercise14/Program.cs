//Prompt the user for a number. Use a for loop to output the squares of all the numbers from 1 to that number.
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
    
    for(int i = 1; i <= userNumber; i++)
    {
        Console.Write($"{i * i} ");
    }
    Console.WriteLine();

    Console.Write("Would you like to continue? (y/n) ");
    string userChoice = Console.ReadLine().ToLower(); 
    if (userChoice == "y")
    {

    }else
    {
        Console.WriteLine("Good bye!");
        proceed = false;
    }
}