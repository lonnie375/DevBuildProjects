//Prompt the user to enter a number. After the user enters a nummber, add "1" to the number and output it  back to the console 

Console.Write("Enter a number: ");
string input = Console.ReadLine();
int userNumber; 
bool correction = int.TryParse(input, out userNumber);

while (!correction)
{
    Console.Write("Please enter a number: ");
    input = Console.ReadLine();
    correction = int.TryParse(input, out userNumber);

}

Console.WriteLine(userNumber + 1);