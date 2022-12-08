//Create an array of size 5 and fill it with the following numbers: 2, 8, 0, 24, 51. Prompt the user to enter a number. If the number is in the array, display the index at which it is located.

int[] myArray = { 2, 8, 0, 24, 51 };

Console.Write("Please provide an integer from 1 - 60: "); 
string userInput = Console.ReadLine();
int userNumber; 
bool test = int.TryParse(userInput, out userNumber);

if (test)
{

}
else
{
    Console.WriteLine("Please enter a number between 1 - 60");
}

int index = Array.IndexOf(myArray, userNumber);

if (myArray.Contains(userNumber))
{
    Console.WriteLine($"The number {userNumber} can be found at index {index}");
}
else
{
    Console.WriteLine("That number is not on the list. Try again");
}
