//We have a new type called Pen which has properties/attributes

Pen gelPen = new Pen("green", 5.0, "Gel", "Medium");
gelPen.Print();

Pen feltpen = new Pen("blue", 4.0, "Felt", "Small"); 
feltpen.Print();
Console.WriteLine();

gelPen.Draw(5);
gelPen.Print();
Console.WriteLine();

gelPen.Draw(7);
gelPen.Print();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine(gelPen);
Console.WriteLine(feltpen);
public class Pen
{
    public string inkColor { get; set; }
    public double Length { get; set; }
    public string pointType { get; set; }
    public string pointSize { get; set; }   
    public int inkAmount { get; set; }

    
    public Pen(string _inkColor, double length, string _pointType, string _pointSize)
    {
        inkColor = _inkColor;
        Length = length;    
        pointType = _pointType;
        pointSize = _pointSize;
        inkAmount = 10; 
    }

    public void Print()
    {
        Console.WriteLine($"This pen.");
        Console.WriteLine($"    color:  {inkColor}  Length: {Length} Type: {pointType} Size: {pointSize} Amount: {inkAmount}");

    }

    public void Draw(int lineLength)
    {
        if (lineLength > inkAmount)
        {
            Console.WriteLine("We do not have enough ink. Please refill.");
        }
        else
        {
            inkAmount -= lineLength;
            if (inkAmount < 0)
            {
                inkAmount = 0;
            }
        }

        
    }
    public void Refill()
    {
        inkAmount = 10; 
    }

    public override string ToString()
    {
        return $"Color: {inkColor}   Length: {Length}   Type: {pointType}   Size: {pointSize}   Amount: {inkAmount}";
    }
}