bool proceed = true;
while (proceed)
{
    Console.Write("Welcome, please choose a shape you would like to draw (1) Rectangle (2) Triangle: ");
    string userInput = Console.ReadLine();
    int shapeSelected;
    bool correction = int.TryParse(userInput, out shapeSelected);
    //Handle if user doesn't enter a number 
    while (!correction)
    {
        Console.Write("Please enter (1) Rectangle or (2) Triangle!");
        userInput = Console.ReadLine();
        correction = int.TryParse(userInput, out shapeSelected);
    }
    if (shapeSelected == 1)
    {
        Console.Write("Enter a rectangle height: ");
        string recInput = Console.ReadLine();
        int recHeight;
        bool recCorrect = int.TryParse(recInput, out recHeight);
        while (!recCorrect)
        {
            recInput = Console.ReadLine();
            recCorrect = int.TryParse(recInput, out recHeight);
        }
        Console.Write("Enter a rectangle width: ");
        string recWInput = Console.ReadLine();
        int recWidth;
        bool recWCorrect = int.TryParse(recWInput, out recWidth);
        while (!recWCorrect)
        {
            recWInput = Console.ReadLine();
            recWCorrect = int.TryParse(recWInput, out recWidth);
        }
        Rectangle(recHeight, recWidth);
    }
    else if (shapeSelected == 2)
    {
        Console.Write("Enter a triangle height: ");
        string heightInput = Console.ReadLine();
        int userHeight;
        bool number = int.TryParse(heightInput, out userHeight);
        while (!number)
        {
            Console.Write("Please enter a triangle height: ");
            heightInput = Console.ReadLine();
            number = int.TryParse(heightInput, out userHeight);
        }
        Console.Write("Enter (1) Right aligned or (2) Left aligned: ");
        string userAlign = Console.ReadLine();
        int userAlignment;
        bool correctAlign = int.TryParse(userAlign, out userAlignment);

        while (!correctAlign)
        {
            Console.Write("Please enter (1) Right aligned or (2) Left aligned: ");
            userAlign = Console.ReadLine();
            correctAlign = int.TryParse(userAlign, out userAlignment);
        }
        if (userAlignment == 2)
        {
            RightAlignedTriangle(userHeight);
        }
        else if (userAlignment == 1)
        {
            LeftAlignedTriangle(userHeight);
        }
    }
    Console.Write("Would you like to draw another shape? Please enter (y) or (n): ");
    string userProceed = Console.ReadLine().ToLower();
    bool incorrect = true;
    while (incorrect)
    {
        if (userProceed == "y")
        {
            incorrect = false;
        }
        else if (userProceed == "n")
        {
            Console.WriteLine("GoodBye!");
            incorrect = false;
            proceed = false;
        }
        else
        {
            Console.Write("Please enter (y) or (n): ");
            userProceed = Console.ReadLine().ToLower();
        }
    }
}
static void RightAlignedTriangle(int userHeight)
{

    for (int i = 1; i <= userHeight; i++)
    {
        for (int j = 1; j <= i; j++)
        {
            Console.Write("*");
        }
        Console.WriteLine();
    }
}
static void LeftAlignedTriangle(int userHeight)
{
    for (int i = 1; i <= userHeight; i++)
    {
        for (int j = 1; j <= userHeight - i; j++)
        {
            Console.Write(" ");
        }
        for (int l = 1; l <= i; l++)
        {
            Console.Write("*");
        }
        Console.WriteLine(" ");
    }
}
static void Rectangle(int recHeight, int recWidth)
{
    for (int i = 0; i < recHeight; i++)
    {
        for (int j = 0; j < recWidth; j++)

            Console.Write("*");
        Console.WriteLine();
    }
}