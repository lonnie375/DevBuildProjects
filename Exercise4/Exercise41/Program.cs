//Prompt the user to enter two numbers.  Divide the two numbers and show only two decimal places.

Console.Write("Enter a number: ");
double firstNumber = double.Parse(Console.ReadLine());

Console.Write("Enter another number: ");
double secondNumber = double.Parse(Console.ReadLine());



double newNumber = firstNumber / secondNumber;



if (secondNumber == 0)
{
    Console.WriteLine("You can not divide by 0.");
}
else
{
    Console.WriteLine($"{firstNumber}/{secondNumber} is approximately {string.Format("{0:F2}", Math.Round(newNumber, 3))}");
}
