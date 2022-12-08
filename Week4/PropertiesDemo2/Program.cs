Rectangle r1 = new Rectangle(10.5m, 8.0m);
Console.WriteLine(r1);

r1.Height = -5; //This is a function call that is going to call the setter and it will print 1
Console.WriteLine(r1.Height);

public class Rectangle
{
    public decimal Length { get; set; }

    private decimal pHeight; // our own private variable 
    public decimal Height 
    {
        get { return pHeight; }
        set { 
            if (value > 0)
            {
                pHeight = value;
            }
            else
            {
                pHeight = 1; 
            }
        }
    } 

    public Rectangle(decimal length, decimal height)
    {
        Length = length;
        Height = height;
    }

    public override string ToString()
    {
        return $"{Length} {Height} Area: {Length * Height}"; 
    }
}