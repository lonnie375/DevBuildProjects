bool proceed = true;

while (proceed)
{

    for (int i = 0; i < 10; i++)
    {
        Console.Write($"{i}");
    }
    Console.WriteLine("\n");
    Console.Write("Would you like to continue (y/n)? ");
    string input = Console.ReadLine().ToLower();

    if (input == "y" || input == "yes")
    {

    }
    else
    {
        Console.WriteLine("Good Bye!");
        proceed = false;
    }

}