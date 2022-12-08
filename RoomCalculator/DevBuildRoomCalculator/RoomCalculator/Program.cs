Console.WriteLine("Welcome to Grand Circus' Room Detail Generator!");

Console.Write("Enter Length: ");
double userLength = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter Width: ");
double userWidth = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter Height: ");
double userHeight = Convert.ToDouble(Console.ReadLine());

double area = userLength * userWidth;
double perimeter = 2 * (userLength + userWidth);
double volume  = userLength * userWidth * userHeight;
double surfaceArea = 2 * ((userWidth * userLength) + (userHeight * userLength) + (userHeight * userWidth));

Console.WriteLine($"Area: {area} ");

Console.WriteLine($"Perimeter: {perimeter}");

Console.WriteLine($"Volume: {volume}");

Console.WriteLine($"Surface Area of the room is: {surfaceArea}");

if (area <= 250)
{
    Console.WriteLine($"This room is considered to be small room.");
}
else if (area < 650)
{
    Console.WriteLine("This room is considered to be a medium room.");
}
else
{
    Console.WriteLine("This room is considered to be a large room.");
}



Console.WriteLine("Thank you for using the Room Detail Generator!");