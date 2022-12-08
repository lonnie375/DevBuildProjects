//Prompt the user to enter a number. After the user enters a number, add ".5" to the number and output it back to the console 

Console.Write("Enter a number: ");
string input = Console.ReadLine();
double userNumber; 
while (!double.TryParse(input, out userNumber))
{
    Console.WriteLine("Pleaes enter a number");
    input = Console.ReadLine(); 
}

Console.WriteLine(userNumber + .5);