Overload newOverload = new Overload();

int sum1 = newOverload.Add(5, 3); 
Console.WriteLine(sum1);

double sum2 = newOverload.Add(5.5, 3.5);
Console.WriteLine(sum2);

public class Overload
{
    public int Add(int x, int y)
    {
        return x + y;
    }

    public double Add(double z, double a)
    {
        return z + a;
    }

}
