//Create a class Triangle, that has three properties, Side1Length, Side2Length, Side3Length. The class should have two methods, CalculatePerimeter, and CalculateArea.
//Let the user enter the length of the triangle's sides.  Create an object based on those lengths and output the triangle's details. Hint: Google Heron's Formula.
Console.Write("Enter the side lengths of a triangle: ");
string[] first = Console.ReadLine().Split();

int a = int.Parse(first[0]);

int b = int.Parse(first[1]);

int c = int.Parse(first[2]);

Triangle userResults = new Triangle(a, b, c);

Console.WriteLine($"The triangle has side lengths {userResults.side1Length}, {userResults.side2Length}, and {userResults.side3Length}. Its area is {userResults.CalculateArea()} and its perimeter is {userResults.CalculatePerimeter()}");
public class Triangle
{
    public int side1Length { get; set; }

    public int side2Length { get; set; }

    public int side3Length { get; set; }

    public Triangle(int side1Length, int side2Length, int side3Length)
    {
        this.side1Length = side1Length;
        this.side2Length = side2Length;
        this.side3Length = side3Length;
    }   

    public int CalculatePerimeter()
    {
        return side1Length + side2Length + side3Length;
    }

    public double CalculateArea()
    {
        double s = CalculatePerimeter() / 2;

        double t = (s - side1Length) * (s - side2Length) * (s - side3Length); 

        return Math.Sqrt(s * t);
    }
}