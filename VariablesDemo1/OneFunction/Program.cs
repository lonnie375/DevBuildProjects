int first = 20; 
int second = 30;
Console.WriteLine("Getting started!");
int product = Multiply(first, second);
Console.WriteLine(product);
Console.WriteLine("All done!");

int product2 = Multiply(first, 50);
Console.WriteLine(product2);
int product3 = Multiply(second, 2);
Console.WriteLine(product3);
int product4 = Multiply(product2, product3);
Console.WriteLine(product4);



static int Multiply(int x, int y)
{
    Console.WriteLine("We are inside the function!");
    Console.WriteLine($"The value of x is {x}");
    Console.WriteLine($"The value of y is {y}"); 
    return x * y;
}