List<Rectangle> rects = new List<Rectangle> ();


Rectangle rect1 = new Rectangle("Fred", 3.5, 4.2);
//Console.WriteLine(rect1);
rects.Add (rect1);

Rectangle rect2 = new Rectangle("Sally", 4.6, 5.5);
//Console.WriteLine(rect2);
rects.Add (rect2);

Console.Write("Which rectangle? ");
string entry = Console.ReadLine();


//Rectangle found = null; 

//foreach(Rectangle rect in rects)
//{
//    if (rect.name == entry)
//    {
       
//        //found = rect;
//        //break; 
//    }
//}

Console.WriteLine(rects.Where(x => x.name == entry).FirstOrDefault());
//if (found != null)
//{
//    Console.WriteLine(found);
//}
//else
//{
//    Console.WriteLine("Sorry not found!");
//}
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
        return $"{name}: {length}x{height}, Area = {length * height}"; 
    }

}