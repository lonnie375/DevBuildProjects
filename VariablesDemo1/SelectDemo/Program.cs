int n = 1; 

if (n == 0)
{
    Console.WriteLine("Zero");
}
else if (n == 1)
{
    Console.WriteLine("One");
}
else if (n == 2)
{
    Console.WriteLine("Two");
}
else
{
    Console.WriteLine("I don't know");
}

switch (n)
{
    case 0:
        Console.WriteLine("Zero");
        break; 
    case 1:
        Console.WriteLine("One");
        break;
    case 2:
        Console.WriteLine("Two");
        break; 
    default:
        Console.WriteLine("I don't know");
        break; 
}