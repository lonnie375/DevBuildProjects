//Use a do-while loop to output "Hello, World!" in a loop. Each time you output "Hello, World" ask the user whether they would like to continue
bool end = false;
do
{
    Console.WriteLine("Hello, World!");

    Console.Write("Would you like to continue (y/n)? ");
    string userInput = Console.ReadLine().ToLower();


    if (userInput == "y" || userInput == "yes")
    {

    }
    else
    {
        Console.WriteLine("GoodBye!");
        end = true;
    }
} while (end == false);
