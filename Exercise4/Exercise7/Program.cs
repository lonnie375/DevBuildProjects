//Use a "do-while loop to run exercise 1 in a loop. Each time yu run the code ask the user whether they would like to continue 

bool correctInput = false;
do
{
    Console.Write("Enter some text: ");
    string input = Console.ReadLine();
    Console.WriteLine(input);
    Console.Write("Would you like to continue (y/n)");
    string userChoice = Console.ReadLine().ToLower(); 

    if (userChoice == "y" || userChoice == "yes")
    {

    }
    else
    {
        Console.WriteLine("GoodBye");
        correctInput = true;
    }
}while (correctInput == false);