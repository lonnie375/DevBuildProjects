Dictionary<string, Rectangle> rects = new Dictionary<string, Rectangle>();

rects["Fred"] = new Rectangle("Fred", 3.5, 4.6);
rects["Sally"] = new Rectangle("Sally", 5.5, 6.6);
rects["Sam"] = new Rectangle("Sam", 10, 11.5);

foreach (var rect in rects)
{
    Console.WriteLine($"Key: {rect.Key} Value: {rect.Value}");
}
public class Rectangle
{
    public string name { get; set; }
    public double length { get; set; }
    public double height { get; set; }

    public Rectangle(string name, double length, double height)
    {
        this.name = name;
        this.length = length;
        this.height = height;
    }

    public override string ToString()
    {
        return $"{length}x{height}";
    }
}