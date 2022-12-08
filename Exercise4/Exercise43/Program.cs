//Create a class called Point, that has two properties, X and Y. Let the user enter an X and Y value to create a Point object.
Console.Write("Enter an X coordiate: ");
int userFirst = int.Parse(Console.ReadLine());

Console.Write("Enter an Y coordinate: ");
int userSecond = int.Parse(Console.ReadLine()); 

Point userInput = new Point(userFirst, userSecond);

Console.WriteLine($"You have created a point object ({userInput.X}, {userInput.Y})");

public class Point
{
    public int X { get; set; }
    public int Y { get; set; }  

    public Point(int x, int y)
    {
       X = x;
       Y = y;
    }

    
}