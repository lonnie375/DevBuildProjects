//Ask the user for an integer 

//Display a table of squares and cubes from 1 to the value entered 

//Ask the user if they want to continue

//Use \t to tab to line up columns properly 


//Provide validation to reject 0 or negative numbers as user input. Make sure they enter a valid number 

//Research formatted strings and right-align the numbers in columns instead of left-aligning them**

//Find the maximum number whose cube will fit in an int, and limit the user input to that number or less** 

bool userContinue = true;
Console.WriteLine("Learn your squares and cubes!");
do
{
    int maxValue = 1290; 

    Console.Write("Enter an Integer: ");

    string input = Console.ReadLine();
    int userInteger;
    bool validation = int.TryParse(input, out userInteger);


    if (validation && userInteger > 0 && userInteger <= maxValue)
    {

    }
    else
    {
        while (validation == false || userInteger < 1 || userInteger > maxValue)
        {
            Console.WriteLine("Please Enter an Integer, please make sure that it is 1290 or less: ");
            input = Console.ReadLine();
            validation = int.TryParse(input, out userInteger);
        }

    }



    Console.WriteLine(String.Format("{0,10}  {1,10}  {2,5}", "Number", "Squared", "Cubed"));
    Console.WriteLine(String.Format("{0,10}  {1,10}  {2,5}", "======", "=======", "====="));
    for (int i = 1; i < userInteger + 1; i++)
    {

        int squared = i * i;
        int cubed = i * i * i;
        Console.WriteLine(String.Format("{0,10}  {1,10}  {2,5}", i, squared, cubed));

    }

    Console.Write("Continue (y/n): ");
    string userInput = Console.ReadLine().ToLower();

    if (userInput == "y")
    {

    }
    else
    {
        userContinue = false;
        Console.WriteLine("Good Bye!");
    }
} while (userContinue == true);

