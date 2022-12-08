//Create a Square class and a list of squares. Then display some statistics for the collection of squares.

List<Square> squareList = new List<Square>();

int perimeterSum = 0;
int areaSum = 0;    


    Console.Write("Enter a number (q to quit): ");
    string userNumber = (Console.ReadLine().ToLower());

    if (userNumber == "q")
    {
        
        
        foreach(Square square in squareList)
        {
            perimeterSum += square.CalculatePerimeter();
            areaSum += square.CalculateArea();

        }

        Console.WriteLine("Would you like to continue (y/n)? ");
        string userContinue = Console.ReadLine().ToLower();
        if (userContinue == "y")
        {

        }
        else
        {
            
            Console.WriteLine("GoodBye!");
        }
        
    }
    else if (userNumber != "q")
    {
        int newNumber = Convert.ToInt32(userNumber);
        Square userInfo = new Square(newNumber);
        double userPerimeter = userInfo.CalculatePerimeter();
        double userArea = userInfo.CalculateArea();
        squareList.Add(userInfo);   

    }

    Console.WriteLine($"{perimeterSum}");





public class Square
{
   
    public int sideLength { get; set; }

    public Square(int _sideLength)
    {
       
        sideLength = _sideLength;
    }

    public int CalculatePerimeter()
    {
         return sideLength * 4;
    }

    public int CalculateArea()
    {
        return sideLength * sideLength;
    }
}


