int value = int.Parse(Console.ReadLine());

bool isGreaterThan10 = false;
Console.WriteLine("===Take 1===");

if (value > 10)
{
    isGreaterThan10 = true; 
}
else
{
    isGreaterThan10 = false;
}

Console.WriteLine(isGreaterThan10);

Console.WriteLine();
Console.WriteLine("==take 2==");


//Performing this using a ternary operator 
isGreaterThan10 = value > 10 ? true : false;

Console.WriteLine(isGreaterThan10);

string response = (value > 10) ? "Greater than 10" : "Less than or equal to 10";

Console.WriteLine(response);