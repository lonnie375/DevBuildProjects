//Prompt the user to enter two numbers. After the user enters the numbers, multiply them and output the product back to the console. 

Console.Write("Enter a number: ");
string firstNumber = Console.ReadLine();
int userFirst; 
bool correct = int.TryParse(firstNumber, out userFirst);

Console.Write("Enter another number: ");
string secondNumber = Console.ReadLine();
int secondUser;
bool correct2 = int.TryParse(secondNumber, out secondUser);

bool right = false; 

while (right == false)
{
    if (correct)
    {
        right = true;
    }
    else if (correct2)
    {
        right = true; 
    }
    else
    {
        Console.Write("Please enter a number: ");
        firstNumber = Console.ReadLine();
        correct = int.TryParse(firstNumber, out userFirst);

        Console.Write("Please enter another number: ");
        secondNumber = Console.ReadLine();
        correct2 = int.TryParse(secondNumber, out secondUser);
    }
}



Console.WriteLine($"The product is {userFirst * secondUser}");