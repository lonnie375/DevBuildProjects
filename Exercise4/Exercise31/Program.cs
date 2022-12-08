//Create an array of size 5 and fill it with the following numbers: 2, 8, 0, 24, 51.
//Prompt the user to enter an index. Display the element in the array at that index.

bool proceed = true;
while (proceed)
{
    int[] numberList = new int[5];

    numberList[0] = 2;
    numberList[1] = 8;
    numberList[2] = 0;
    numberList[3] = 24;
    numberList[4] = 51;

    Console.Write("Enter an index of the array: ");
    string input = Console.ReadLine().ToLower();
    int userIndex;
    bool correct = int.TryParse(input, out userIndex);


    Console.WriteLine($"The value at index {userIndex} is {numberList[userIndex]}");

    Console.Write("Would you like to continue (y/n)? "); 
    string userChoice = Console.ReadLine().ToLower();

    if (userChoice == "y")
    {

    }
    else
    {
        Console.WriteLine("GoodBye!");
        proceed = false;
    }
}