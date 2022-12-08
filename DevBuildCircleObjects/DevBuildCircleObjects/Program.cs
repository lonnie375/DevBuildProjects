Console.WriteLine("Welcome to the DevBuild Tester");

bool play = true;
while (play)
{

    Console.Write("Please type Circle, Rectangle, or Sphere: ");
    string userSelection = Console.ReadLine().ToLower();

    if (userSelection == "circle")
    {
        bool proceed = true;
        while (proceed)
        {
            Console.Write("Enter radius: ");
            string input = Console.ReadLine();
            double userRadius;
            bool correctInput = double.TryParse(input, out userRadius);

            if (correctInput)
            {

            }
            else
            {
                while (!correctInput)
                {


                    Console.WriteLine("Please enter a radius number: ");
                    input = Console.ReadLine();
                    correctInput = double.TryParse(input, out userRadius);
                }
            }

            Circle userCircle = new Circle(userRadius);
            Console.Write($"Circumference: {userCircle.FormattedCalculateCircumference()}");
            Console.WriteLine();
            Console.Write($"Area:      {userCircle.FormattedCalculateArea()}");

            Console.WriteLine();
            Console.Write("Continue? (y/n):  ");
            string userInput = Console.ReadLine().ToLower();

            if (userInput == "y")
            {
                
            }
            else
            {
                Console.WriteLine($"Goodbye. You created {Circle.counter} Circle object(s)");
                proceed = false;
               play = false;
            }
        }
    }
    else if (userSelection == "rectangle")
    {

        bool userProceed = true;
        while (userProceed)
        {
            Console.Write("Enter length: ");
            string input = Console.ReadLine();
            double userLength;
            bool correctInput = double.TryParse(input, out userLength);

            Console.Write("Enter width: ");
            string usersInput = Console.ReadLine();
            double userWidth;
            bool userCorrectInput = double.TryParse(usersInput, out userWidth);

            if (correctInput & userCorrectInput)
            {

            }
            else
            {
                while (!correctInput || !userCorrectInput)
                {


                    Console.Write("Please enter a length: ");
                    input = Console.ReadLine();
                    correctInput = double.TryParse(input, out userLength);
                    Console.Write("Please enter a width: ");
                    usersInput = Console.ReadLine();
                    userCorrectInput = double.TryParse(usersInput, out userWidth);

                }
            }

            Rectangle userCircle = new Rectangle(userLength, userWidth);
            Console.Write($"Circumference: {userCircle.FormattedCalculateRectangleCircumference()}");
            Console.WriteLine();
            Console.Write($"Area:      {userCircle.FormattedCalculateRectangleArea()}");

            Console.WriteLine();
            Console.Write("Continue? (y/n):  ");
            string userInput = Console.ReadLine().ToLower();

            if (userInput == "y")
            {
                
            }
            else
            {
                Console.WriteLine($"Goodbye. You created {Rectangle.counter} Circle object(s)");
                userProceed = false;
                play = false;
            }
        }
    }
    else if (userSelection == "sphere")
    {
        bool proceed = true;
        while (proceed)
        {
            Console.Write("Enter radius: ");
            string input = Console.ReadLine();
            double userRadius;
            bool correctInput = double.TryParse(input, out userRadius);

            if (correctInput)
            {

            }
            else
            {
                while (!correctInput)
                {


                    Console.WriteLine("Please enter a radius number: ");
                    input = Console.ReadLine();
                    correctInput = double.TryParse(input, out userRadius);
                }
            }

            Sphere userCircle = new Sphere(userRadius);
            Console.Write($"Circumference: {userCircle.FormattedCalculateCircumference()}");
            Console.WriteLine();
            Console.Write($"Area:      {userCircle.FormattedCalculateArea()}");

            Console.WriteLine();
            Console.Write("Continue? (y/n):  ");
            string userInput = Console.ReadLine().ToLower();

            if (userInput == "y")
            {
               
            }
            else
            {
                Console.WriteLine($"Goodbye. You created {Sphere.counter} Sphere object(s)");
                proceed = false;
                play = false; 
            }
        }
    }
    else
    {
        

    }
    
}

//Print Circumference

//Print Area 

//Ask if they want to continue 

//If not Goodby you created 2 circle objections. 






public class Circle
{
    public static int counter = 0; 
    public double Radius { get; set; }
    

    //Constructor 
    public Circle (double radius)
    {
        Circle.counter++; 
        Radius = radius;
     
    }

    //Methods 
    public double CalculateCircumference()
    {
        double circumference = 2 * Math.PI * Radius;
        return circumference;
    }

    public string FormattedCalculateCircumference()
    {
        return string.Format("{0:0.00}", CalculateCircumference()); 
    }
    public double CalculateArea()
    {
        double area = Math.PI * (Radius * Radius);
        return area;
    }

    public string FormattedCalculateArea()
    {
        return string.Format("{0:0.00}", CalculateArea());
    }

}

public class Rectangle
{
    public static int counter = 0; 
    public double length { get; set; }
    public double width { get; set; }

    public Rectangle(double _length, double _width)
    {
        Rectangle.counter++;
        length = _length;
        width = _width;
    }

    public double CalculateRectangleCircumference()
    {
        return 2 * (length + width);
    }

    public string FormattedCalculateRectangleCircumference()
    {
        return string.Format("{0:0.00}", CalculateRectangleCircumference());
    }

    public double CalculateRectangleArea()
    {
        return length * width;
    }

    public string FormattedCalculateRectangleArea()
    {
        return string.Format("{0:0.00}", CalculateRectangleArea());    
    }
        
}

public class Sphere
{
    public static int counter = 0; 
    public double radius { get; set; }

    public Sphere(double radius)
    {
        this.radius = radius;
    }



    public double CalculateCircumference()
    {
       Sphere.counter++;
        return 2 * Math.PI * radius;
    }

    public string FormattedCalculateCircumference()
    {
        return string.Format("{0:0.00}", CalculateCircumference());
    }
    public double CalculateArea()
    {
        
        return 4 * Math.PI * radius * radius;
    }

    public string FormattedCalculateArea()
    {
        return string.Format("{0:0.00}", CalculateArea());
    }

}