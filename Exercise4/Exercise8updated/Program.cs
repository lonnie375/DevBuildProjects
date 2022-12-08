
//Exercise 2 in a Do-While Loop Asking if they want to continue 
//bool proceed = true; 
//do
//{
//    Console.Write("Enter a number: ");
//    string input = Console.ReadLine();
//    int userNumber;
//    bool correction = int.TryParse(input, out userNumber);

//    while (!correction)
//    {
//        Console.Write("Please enter a number: ");
//        input = Console.ReadLine();
//        correction = int.TryParse(input, out userNumber);

//    }

//    Console.WriteLine(userNumber + 1);

//    Console.Write("Would you like to continue (y/n): ");
//    string userChoice = Console.ReadLine().ToLower(); 

//    if (userChoice == "y" || userChoice == "yes")
//    {
//       proceed = true;
//    }
//    else
//    {
//        Console.WriteLine("GoodBye!");
//        proceed = false;
//    }


//}while (proceed);






//Exercise 3 in a Do-While Loop Asking if they want to continue 
//bool proceed = true; 
//do
//{
//    Console.Write("Enter a number: ");
//    string input = Console.ReadLine();
//    double userNumber;
//    while (!double.TryParse(input, out userNumber))
//    {
//        Console.WriteLine("Pleaes enter a number");
//        input = Console.ReadLine();
//    }

//    Console.WriteLine(userNumber + .5);

//    Console.Write("Would you like to continue (y/n): ");
//    string user = Console.ReadLine().ToLower();

//    if (user == "y" || user == "yes")
//    {

//    }
//    else
//    {
//        Console.WriteLine("GoodBye");
//        proceed = false;
//    }


//}while (proceed);




//Exercise 4 in a Do-While Loop Asking if they want to continue 

bool proceed = true;
do
{
    bool correct = false;
    Console.Write("Enter a number: ");
    string userNumber = Console.ReadLine();
    int firstNumber;
    bool userInput = int.TryParse(userNumber, out firstNumber);

    Console.Write("Enter another number: ");
    string userSecondNumber = Console.ReadLine();
    int secondNumber;
    bool secondInput = int.TryParse(userSecondNumber, out secondNumber);

    while (correct == false)
    {


        if (userInput)
        {
            correct = true;
        }
        else if (secondInput)
        {
            correct = true;
        }
        else
        {
            Console.Write("Please enter your first number");
            userNumber = Console.ReadLine();
            userInput = int.TryParse(userNumber, out firstNumber);

            Console.Write("Please enter your second number");
            userSecondNumber = Console.ReadLine();
            secondInput = int.TryParse(userSecondNumber, out secondNumber);
        }

    }
    Console.WriteLine($"The sum is {firstNumber + secondNumber}");

    Console.Write("Would you like to continue? (y/n) ");
    string userResponse = Console.ReadLine().ToLower();
    if (userResponse == "y" || userResponse == "yes")
    {

    }
    else
    {
        Console.WriteLine("Good Bye!");
        proceed = false;
    }

} while (proceed); 

