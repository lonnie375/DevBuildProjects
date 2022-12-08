//Create an array of size 5 and fill it with the following numbers: 16, 32, 64, 128, 256.
//Prompt the user to enter a command, 'half' or 'double'.  If the user enters 'half', half all the elements in the array.
//If the user enters 'double', double all the elements in the array.
int[] number = new int[5];

number[0] = 16;
number[1] = 32;
number[2] = 64;
number[3] = 128;
number[4] = 256;


bool proceed = true;
while (proceed)
{


    Console.Write("Enter a command (half/double): ");
    string input = Console.ReadLine().ToLower();


    if (input == "half")
    {
        Console.Write("The array now contains: ");

        
        foreach (int i in number)
        {
            Console.Write("{0}, ", i / 2);

        }

    }
    else if (input == "double")
    {
        Console.Write("The array now contains: ");
        foreach (int i in number)
        {
            Console.Write("{0}, ", i * 2);
        }
    }
    Console.WriteLine();
    Console.Write("Would you like to continue (y/n)? ");
    string userChoice = Console.ReadLine().ToLower();
    if (userChoice == "y")
    {

    }
    else
    {
        Console.WriteLine("GoodBye");
        proceed = false;
    }
}