using ClassInSeperateFile;

Rectangle rect = new Rectangle(10.1, 20.2, "First");
Console.WriteLine(rect);
Console.WriteLine($"Number of instances: {Rectangle.count}");
Console.WriteLine();
Rectangle rect2 = new Rectangle(2.5, 3.6, "Second");
Console.WriteLine(rect2);
Console.WriteLine($"Number of instances: {Rectangle.count}");
Rectangle rect3 = new Rectangle(1.1, 2.2, "Third");
Console.WriteLine(rect3);

Console.WriteLine($"Number of instances: {Rectangle.count}");


string entry = "10"; 
Console.WriteLine(int.Parse(entry));