//Enhance the point class in the previous exercise by adding a CalculateDistance method.  The distance method will calculate the distance of a point from the origin, (0,0).  
Console.Write("Enter an X coordiate: ");
int userFirst = int.Parse(Console.ReadLine());

Console.Write("Enter an Y coordinate: ");
int userSecond = int.Parse(Console.ReadLine());

Point userInput = new Point(userFirst, userSecond);



Console.WriteLine($"You have created a point object ({userInput.X}, {userInput.Y}). It has a distance of {userInput.GetDistance(userFirst, userSecond)} ");

public class Point
{
    public int X { get; set; }
    public int Y { get; set; }

    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }


    public double GetDistance(int x, int y)
    {
        return Math.Sqrt((x * x) + (y * y)); ; 
    }
}