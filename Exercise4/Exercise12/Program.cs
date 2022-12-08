//Output all the numbers from 9 to 0. Use a for loop to output all the numbers from 9 to 0.

bool proceed = true; 
while (proceed)
{
    for (int i = 9; i >= 0; i--)
    {
        Console.Write(i);
    }
    Console.WriteLine();
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