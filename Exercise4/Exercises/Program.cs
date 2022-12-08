//Prompt the user to enter two numbers. After the user enters the numbers, add them together and output the sum back to the console. 

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



