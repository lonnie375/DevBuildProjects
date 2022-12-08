//Create a class Square that has one property, SideLength. The class should have two methods, CalculatePerimeter, and CalculateArea. Let the user enter the length of the square's side.
//Create an object based on that length and output details of the square.
Console.Write("Enter a side length: "); 
int userLength = int.Parse(Console.ReadLine());

Square userSquare = new Square(userLength);

Console.WriteLine($"The square has a side length of {userLength}. Its area is {userSquare.CalculateArea(userLength)} and its perimeter is {userSquare.CalculatePerimeter(userLength)}.");


public class Square
{
    public int sideLength { get; set; }

    public Square(int sideLength)
    {
        this.sideLength = sideLength;
    }

    public int CalculatePerimeter(int userInput)
    {
        return 4 * userInput; 
    }

    public int CalculateArea(int userInput)
    {
        return userInput * userInput; 
    }
}