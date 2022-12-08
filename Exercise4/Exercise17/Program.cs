//Use a for loop to output a triangle of asterisks with a height of ten.


for (int i = 1; i < 10; i++)
{
    for (int j = 1; j <= 10 - i; j++)
        Console.Write(" ");
    for (int j = 1; j <= 2 * i - 1; j++)
        Console.Write("*");
    Console.Write("\n");
}





















//for (int i = 1; i <= 10; i++)
//{

//    for (int j = 1; j <= i; j++)
//    {
//        Console.Write("*");
//    }
//    Console.WriteLine();
//}
