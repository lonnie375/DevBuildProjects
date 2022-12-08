
int first = TimesTwo(5);
Console.WriteLine(first);

int second = SomeNumber();
Console.WriteLine(second);

double circle = Radius(3);
Console.WriteLine(circle);

double area2 = TriangleArea(3, 3);
Console.WriteLine(area2);

PrintArea(10);

static int TimesTwo(int num)
{
    int result = num * 2; 
    return result;
}

static int SomeNumber()
{
    return 20; 
}

static double Radius(double radius)
{
    return Math.PI * radius * radius; 
}

static double TriangleArea(int height, int width)
{
    return height * width / 2.0;  
}

static void PrintArea(double radius)
{
    double area = Radius(radius);
    Console.WriteLine(area);
}