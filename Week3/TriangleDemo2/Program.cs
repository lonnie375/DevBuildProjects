Triangle first = new Triangle(4, 3);

double area = first.GetArea();
Console.WriteLine(area);
Console.WriteLine(first.GetHypotenuse());
Console.WriteLine(first.GetPerimeter());


//first.height => can't do this now because the property is now private. 

public class Triangle
{
    // We have a package like a capsule 
    // The verb we use is "encapsulate" 
    // This is the objects ability to hide data and behavior that are not necessary to its user. 
    //Public, private, protected, internal, and protected internal 
    private double length { get; set; }
    private double height { get; set; }
   
    private double Area { get; set; }

    //Create a constructor 
    public Triangle(double _length, double _height)
    {
        length = _length;
        height = _height;
        Area = length * height / 2; 
    }






    //Methods 
    public double GetArea()
    {
        return Area; 

    }
    public double GetHypotenuse()
    {
        return Math.Sqrt(length * length + height * height);
    }

    public double GetPerimeter()
    {
        return length + height + GetHypotenuse();
    }
}