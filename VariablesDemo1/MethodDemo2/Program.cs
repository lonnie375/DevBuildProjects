//Pass by reference 

double first = 3.5;
double second = 4.5;
double area = RectangleArea(ref first, ref second);
Console.WriteLine($"Rectangle {first} by {second} has an area {area}");



static double RectangleArea(ref double length, ref double width)
{
    double result = length * width;
    length = 100;
    width = 100;
    return result;
}

//Ref allows you to  change the parametrs to be what's inside of the code. 


double result;
bool worked = Divide(10, 2, out result);
Console.WriteLine(worked);
Console.WriteLine(result);

if (worked)
{
    Console.WriteLine("$Great! The answer is {result}"); 
}
else
{
    Console.WriteLine("Sorry, you cannot divide by zero");
}

static bool Divide(double num1, double num2, out double result)
{
    if (num2 == 0)
    {
        result = 0; 
        return false;
    }
    else
    {
        result = num1 / num2;
        return true;
    }
}



