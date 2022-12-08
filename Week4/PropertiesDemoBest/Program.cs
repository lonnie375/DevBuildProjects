Rectangle r1 = new Rectangle(10.5m, 3.6m);
Console.WriteLine(r1);

public class Rectangle
{

    //Just add on get; set; to make them properties and you are good to go. 
    public decimal Length { get; set; }

    public decimal Height { get; set; }
   
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