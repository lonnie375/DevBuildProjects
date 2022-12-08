//Create an array of size 5 and fill it with the following numbers: 2, 8, 0, 24, 51.
//Let the user change the array by specifying an index and a replacement number.

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
    string userIndex = Console.ReadLine();
    int usersIndex;
    bool correct = int.TryParse(userIndex, out usersIndex);

    if (usersIndex > numberList.Length)
    {
        Console.Write("That is not a valid index. Would you like to continue (y/n)? ");
        string indexChange = Console.ReadLine().ToLower();

        if (indexChange == "y")
        {
            Console.Write("Please enter an index of the array.");
            userIndex = Console.ReadLine();
            correct = int.TryParse(userIndex, out usersIndex);
        }
        else
        {
            Console.WriteLine("GoodBye");
            proceed = false;
        }
    }

    Console.Write($"The value at index {usersIndex} is {numberList[usersIndex]}. Would you like to change it (y/n)? ");
    string userChange = Console.ReadLine().ToLower();

    if (userChange == "y")
    {
        Console.Write($"Enter the new value at index {usersIndex}: ");
        string newValue = Console.ReadLine(); 
        int newIndex; 
        bool correction = int.TryParse(newValue, out newIndex);

        numberList[usersIndex] = newIndex;

        Console.WriteLine($"The value at the index {usersIndex} is {numberList[usersIndex]}");


    }
    else
    {
        Console.WriteLine("GoodBye");
        proceed=false;
    }
}