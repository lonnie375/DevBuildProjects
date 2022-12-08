List<string> myList = new List<string>();
myList.Add("Walking Dead"); 

//Firstpen is an objuect that inside it has four variables 
Pen firstpen = new Pen();

firstpen.inkColor = "red";
firstpen.length = 5.23;
firstpen.pointType = "Gel";
firstpen.pointSize = "Small";
firstpen.inkAmout = 5; 

Console.WriteLine(firstpen.inkColor);
Console.WriteLine(firstpen.length);
Console.WriteLine(firstpen.pointType);
Console.WriteLine(firstpen.pointSize);
Console.WriteLine(firstpen.inkAmout);
Console.WriteLine();

Console.WriteLine("Let's draw the firstpen!");
firstpen.Draw();
Console.WriteLine($"The ink is now {firstpen.inkAmout}");

Pen secondpen = new Pen();  
secondpen.inkColor = "blue";
secondpen.length = 4.5;
secondpen.pointType = "Ball Point";
secondpen.pointSize = "Medium";
secondpen.inkAmout = 2; 
Console.WriteLine(secondpen.inkColor);
Console.WriteLine(secondpen.length);
Console.WriteLine(secondpen.pointType);
Console.WriteLine(secondpen.pointSize);
Console.WriteLine(secondpen.inkAmout);

Console.WriteLine("Lets do two drawings with secondpen!");
secondpen.Draw();
secondpen.Draw(); 
Console.WriteLine($"secondpen now has ink level {secondpen.inkAmout}");
Console.WriteLine($"firstpen still has ink level {firstpen.inkAmout}");
Console.WriteLine();

secondpen.Draw();
Console.WriteLine($"secondpen now has ink level {secondpen.inkAmout}");
Console.WriteLine();
//refill 
secondpen.Refill();
Console.WriteLine($"secondpen now has ink level {secondpen.inkAmout}");
Console.WriteLine();
Console.WriteLine($"Lets refill firstpen with green ink");
firstpen.Refill("green");
Console.WriteLine($"first pen has ink color {firstpen.inkColor}");
Console.WriteLine($"first pen has ink amount {firstpen.inkAmout}");

Console.WriteLine();
Console.WriteLine();

//We are using the first constructor here 
Pen thirdpen = new Pen();
Console.WriteLine(thirdpen.inkAmout);
Console.WriteLine();

//We are using the second constructor here 
Pen fourthPen = new Pen("pink");
Console.WriteLine(fourthPen.inkAmout);
Console.WriteLine(fourthPen.inkColor);

public class Pen
{
    public string inkColor { get; set; }
    public double length { get; set; } 
    public string pointType { get; set; }
    public string pointSize { get; set; }
    public int inkAmout { get; set; }   
    /*
    public Pen(string inkColor, double length, string pointType, string pointSize, int inkAmout)
    {
        this.inkColor = inkColor;
        this.length = length;
        this.pointType = pointType;
        this.pointSize = pointSize;
        this.inkAmout = inkAmout;   
    }
    */

    public Pen()
    {
        inkAmout = 10;
        inkColor = "black"; 
    }

    public Pen(string color)
    {
        inkColor = color;
        inkAmout = 10; 
    }

    //Create methods to track the ink level and when it needs to be refilled 
    //Draw() is going to decrease the inkAmount by one 
    //Refill is going to change the inkLevel back to 10 each time. 

    public void Draw()
    {
        if (inkAmout > 0)
        {
            inkAmout--;
        }
        
    }

    //Sets ink amount back to 10 
    public void Refill()
    {
            inkAmout = 10;  
        
    }

    //Refill function that allows us to select inkColor

    public void Refill(string newColor)
    {
        inkColor = newColor;
        inkAmout = 10; 
    }

}
