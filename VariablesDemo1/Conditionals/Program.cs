//Console.WriteLine("What is your name?");
//string entry = Console.ReadLine();
//Console.WriteLine($"Great to meet you, {entry}");

string entry = Console.ReadLine();
int n = int.Parse(entry);

if (n > 50)
{
    Console.WriteLine("Yes, n is greater than 50.");
    Console.WriteLine($"n is {n}");
}
else
{
    Console.WriteLine("No, n is not greater than 50.");
    Console.WriteLine($"n is {n}");
}
if ( (n>3) && (n<10))
{
    Console.WriteLine("Yes, n is between 3 and 10.");
}
else
{
    Console.WriteLine("No,n is not between 3 and 10.");
}


//if (false)
//{
//    Console.WriteLine("It is evaluated to true");
//}
//else
//{
//    Console.WriteLine("It is evaluated to false");
//}

