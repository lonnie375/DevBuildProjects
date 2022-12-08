//Enhance the point class in the previous exercise by adding a CalculateMidpoint method.
//The CalculateMidpoint will take as an argument another point instance and return the midpoint between the current ('this') object and the point passed in.
//Its method signature will look like: Point CalculateMidpoint(Point other)


Console.Write("Enter coordinates for a point: ");
string[] first = Console.ReadLine().Split();

int a = int.Parse(first[0]);    

int b = int.Parse(first[1]);


Console.Write("Enter coordinates for another point: ");
string[] second = Console.ReadLine().Split();

int x = int.Parse(second[0]);

int y = int.Parse(second[1]);

Point firstPair = new Point(a, b);
Point secondPair = new Point(x, y);
Console.WriteLine($"The midpoint between ({firstPair.X}, {firstPair.Y}) and ({secondPair.X}, {secondPair.Y}) is {firstPair.GetMidPoint(firstPair.X, firstPair.Y, secondPair.X, secondPair.Y)}");



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

    public string GetMidPoint(int a, int b, int x, int y)
    {
        double mid1 = (a + x) / 2; 
        double mid2 = (b + y) / 2;


        return $"{mid1}, {mid2}"; 
    }
}
